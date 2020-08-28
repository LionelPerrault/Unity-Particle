using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

namespace Coffee.UIExtensions
{
    public static class UIParticleUpdater
    {
        static readonly List<UIParticle> s_ActiveParticles = new List<UIParticle>();
        static MaterialPropertyBlock s_Mpb;
        static ParticleSystem.Particle[] s_Particles = new ParticleSystem.Particle[2048];


        public static void Register(UIParticle particle)
        {
            if (!particle) return;
            s_ActiveParticles.Add(particle);

            MeshHelper.Register();
            BakingCamera.Register();
        }

        public static void Unregister(UIParticle particle)
        {
            if (!particle) return;
            s_ActiveParticles.Remove(particle);

            MeshHelper.Unregister();
            BakingCamera.Unregister();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#endif
        [RuntimeInitializeOnLoadMethod]
        private static void InitializeOnLoad()
        {
            Canvas.willRenderCanvases -= Refresh;
            Canvas.willRenderCanvases += Refresh;
        }

        private static void Refresh()
        {
            for (var i = 0; i < s_ActiveParticles.Count; i++)
            {
                try
                {
                    Refresh(s_ActiveParticles[i]);
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            }
        }

        private static void Refresh(UIParticle particle)
        {
            if (!particle) return;

            Profiler.BeginSample("Modify scale");
            ModifyScale(particle);
            Profiler.EndSample();

            Profiler.BeginSample("Bake mesh");
            BakeMesh(particle);
            Profiler.EndSample();

            if (QualitySettings.activeColorSpace == ColorSpace.Linear)
            {
                Profiler.BeginSample("Modify color space to linear");
                particle.bakedMesh.ModifyColorSpaceToLinear();
                Profiler.EndSample();
            }

            Profiler.BeginSample("Set mesh to CanvasRenderer");
            particle.canvasRenderer.SetMesh(particle.bakedMesh);
            Profiler.EndSample();

            Profiler.BeginSample("Update Animatable Material Properties");
            // UpdateAnimatableMaterialProperties(particle);
            Profiler.EndSample();
        }

        private static void ModifyScale(UIParticle particle)
        {
            if (!particle.ignoreCanvasScaler || !particle.canvas) return;

            // Ignore Canvas scaling.
            var s = particle.canvas.rootCanvas.transform.localScale;
            var modifiedScale = new Vector3(
                Mathf.Approximately(s.x, 0) ? 1 : 1 / s.x,
                Mathf.Approximately(s.y, 0) ? 1 : 1 / s.y,
                Mathf.Approximately(s.z, 0) ? 1 : 1 / s.z);

            // Scale is already modified.
            var transform = particle.transform;
            if (Mathf.Approximately((transform.localScale - modifiedScale).sqrMagnitude, 0)) return;

            transform.localScale = modifiedScale;
        }

        private static Matrix4x4 GetScaledMatrix(ParticleSystem particle)
        {
            var transform = particle.transform;
            var main = particle.main;
            var space = main.simulationSpace;
            if (space == ParticleSystemSimulationSpace.Custom && !main.customSimulationSpace)
                space = ParticleSystemSimulationSpace.Local;

            switch (space)
            {
                case ParticleSystemSimulationSpace.Local:
                    return Matrix4x4.Rotate(transform.rotation).inverse
                           * Matrix4x4.Scale(transform.lossyScale).inverse;
                case ParticleSystemSimulationSpace.World:
                    return transform.worldToLocalMatrix;
                case ParticleSystemSimulationSpace.Custom:
                    // #78: Support custom simulation space.
                    return transform.worldToLocalMatrix
                           * Matrix4x4.Translate(main.customSimulationSpace.position);
                default:
                    return Matrix4x4.identity;
            }
        }

        private static void BakeMesh(UIParticle particle)
        {
            // Clear mesh before bake.
            MeshHelper.Clear();
            particle.bakedMesh.Clear(false);

            // if (!particle.isValid) return;

            // Get camera for baking mesh.
            var camera = BakingCamera.GetCamera(particle.canvas);
            var root = particle.transform;
            var rootMatrix = Matrix4x4.Rotate(root.rotation).inverse
                             * Matrix4x4.Scale(root.lossyScale).inverse;
            var scaleMatrix = particle.ignoreCanvasScaler
                ? Matrix4x4.Scale(particle.canvas.rootCanvas.transform.localScale.x * particle.scale * Vector3.one)
                : Matrix4x4.Scale(particle.scale * Vector3.one);

            // Cache position
            var position = particle.transform.position;
            var diff = (position - particle.cachedPosition) * (1 - 1 / particle.scale);
            particle.cachedPosition = position;

            for (var i = 0; i < particle.particles.Count; i++)
            {
                // No particle to render.
                var currentPs = particle.particles[i];
                if (!currentPs || !currentPs.IsAlive() || currentPs.particleCount == 0) continue;

                // Calc matrix.
                var matrix = rootMatrix;
                if (currentPs.transform != root)
                {
                    if (currentPs.main.simulationSpace == ParticleSystemSimulationSpace.Local)
                    {
                        var relativePos = root.InverseTransformPoint(currentPs.transform.position);
                        matrix = Matrix4x4.Translate(relativePos) * matrix;
                    }
                    else
                    {
                        matrix = matrix * Matrix4x4.Translate(-root.position);
                    }
                }
                else
                {
                    matrix = GetScaledMatrix(currentPs);
                }

                // Set transform
                MeshHelper.SetTransform(scaleMatrix * matrix);

                // Extra world simulation.
                if (currentPs.main.simulationSpace == ParticleSystemSimulationSpace.World && 0 < diff.sqrMagnitude)
                {
                    var count = currentPs.particleCount;
                    if (s_Particles.Length < count)
                    {
                        var size = Mathf.NextPowerOfTwo(count);
                        s_Particles = new ParticleSystem.Particle[size];
                    }

                    currentPs.GetParticles(s_Particles);
                    for (var j = 0; j < count; j++)
                    {
                        var p = s_Particles[j];
                        p.position += diff;
                        s_Particles[j] = p;
                    }

                    currentPs.SetParticles(s_Particles, count);
                }

                // Bake main particles.
                var r = currentPs.GetComponent<ParticleSystemRenderer>();
                if (CanBakeMesh(r))
                {
                    var m = MeshHelper.GetTemporaryMesh(i * 2);
                    r.BakeMesh(m, camera, true);

                    if (m.vertexCount == 0)
                        MeshHelper.DiscardTemporaryMesh();
                    else
                    {
                        var index = MeshHelper.activeMeshIndices.BitCount() - 1;
                        particle.UpdateMaterialProperties(r, index);
                    }
                }

                // Bake trails particles.
                if (currentPs.trails.enabled)
                {
                    var m = MeshHelper.GetTemporaryMesh(i * 2 + 1);
                    try
                    {
                        r.BakeTrailsMesh(m, camera, true);

                        if (m.vertexCount == 0)
                            MeshHelper.DiscardTemporaryMesh();
                    }
                    catch
                    {
                        MeshHelper.DiscardTemporaryMesh();
                    }
                }
            }


            // Set active indices.
            particle.activeMeshIndices = MeshHelper.activeMeshIndices;

            // Combine
            MeshHelper.CombineMesh(particle.bakedMesh);
        }

        private static bool CanBakeMesh(ParticleSystemRenderer renderer)
        {
            // #69: Editor crashes when mesh is set to null when `ParticleSystem.RenderMode = Mesh`
            if (renderer.renderMode == ParticleSystemRenderMode.Mesh && renderer.mesh == null) return false;

            // #61: When `ParticleSystem.RenderMode = None`, an error occurs
            if (renderer.renderMode == ParticleSystemRenderMode.None) return false;

            return true;
        }

        /// <summary>
        /// Copy the value from MaterialPropertyBlock to CanvasRenderer
        /// </summary>
        private static void UpdateAnimatableMaterialProperties(UIParticle particle, ParticleSystemRenderer renderer)
        {
#if UNITY_EDITOR
            if (!Application.isPlaying) return;
#endif
            if (0 == particle.m_AnimatableProperties.Length) return;
            if (0 == particle.canvasRenderer.materialCount) return;

            var mat = particle.canvasRenderer.GetMaterial(0);
            if (!mat) return;

            // #41: Copy the value from MaterialPropertyBlock to CanvasRenderer
            if (s_Mpb == null)
                s_Mpb = new MaterialPropertyBlock();
            renderer.GetPropertyBlock(s_Mpb);
            foreach (var ap in particle.m_AnimatableProperties)
            {
                ap.UpdateMaterialProperties(mat, s_Mpb);
            }

            s_Mpb.Clear();
        }
    }
}
