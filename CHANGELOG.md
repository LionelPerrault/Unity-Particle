# [3.0.0-preview.19](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.18...v3.0.0-preview.19) (2020-08-28)


### Bug Fixes

* baking camera settings for camera space ([436c5e4](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/436c5e47f75c3e167dcd77c188847e9d7d6ea68d))
* fix local simulation ([7add9de](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/7add9defb70be29ddbe536d854591c2e0d9e83fa))


### Features

* add menu to create UIParticle ([2fa1843](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/2fa18431f0c8c4aeadfdd1cb98eeeef5ac6970a0))
* add play/pause/stop api ([f09a386](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/f09a386bc59fbab8143f7f0b814c8684aea7f27c))
* support for changing rendering orders ([745d4a5](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/745d4a598846b3e77d1071433079fdd5140921a8))
* Support for child ParticleSystem rendering ([4ee90be](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/4ee90be17c68bf405f81f432615a3eebaa022366))
* UIParticle for trail is no longer needed ([466e43c](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/466e43cf931d211907419f804a90776a0d9f4906))


### BREAKING CHANGES

* The child UIParticle is no longer needed.

# [3.0.0-preview.18](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.17...v3.0.0-preview.18) (2020-08-19)


### Bug Fixes

* AsmdefEx is no longer required ([50e749c](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/50e749c183def5e97affa7e6ae9f3ceb69247825))
* fix camera for baking mesh ([6395a4f](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/6395a4fa744a46551593185711d6545a94d8b456))
* support .Net Framework 3.5 (again) ([23fcb06](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/23fcb06bf9169ee160ccd8adb2cc3aab1a30186a))


### Features

* 3.0.0 updater ([f99292b](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/f99292b9a15c9c085efacc0330d6b848669fadfa))
* add menu to create UIParticle ([14f1c78](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/14f1c782ff0f2b67d85d7c9ad0cf662da1dd1fc6))
* Combine baked meshes to improve performance ([633d058](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/633d058756fde776a7e5192a0f023adf6eb0ca7b))
* improve performance ([77c056a](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/77c056ad5f2918efe457883f3b0361f952600568))
* optimization for vertices transforms and adding node for trails ([e070e8d](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/e070e8d5ee205c25a1e3be5d3178821d4a8265d0)), closes [#75](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/75)
* option to ignoring canvas scaling ([fe85fed](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/fe85fed3c0ad2881578ff68722863d65dfa4db7a))
* support 3d scaling ([42a84bc](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/42a84bc5e130aed3cf5e57dcd6a9d8dc94deb641))
* support custom simulation space ([a83e647](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/a83e64761c008e88ff328a2609118806e97f19cf)), closes [#78](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/78)
* support for particle systems including trail only ([f389d39](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/f389d39953c85b97482b12d1c8578ecaeddacd18)), closes [#61](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/61)


### BREAKING CHANGES

* The bake-task has changed significantly. It may look different from previous versions.

# [3.0.0-preview.17](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.16...v3.0.0-preview.17) (2020-08-13)


### Bug Fixes

* The type or namespace name 'U2D' does not exist in the namespace 'UnityEditor.Experimental' in Unity 2019.3 or later ([930199e](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/930199e5e42920825b27d5bf3e2b2a4bda77fa14)), closes [#82](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/82)

# [3.0.0-preview.16](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.15...v3.0.0-preview.16) (2020-08-12)


### Bug Fixes

* texture sheet animation module Sprite mode not working ([30d1d5d](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/30d1d5d3cc67234a8cd985e98f181aff2a8bd8ef)), closes [#79](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/79)

# [3.0.0-preview.15](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.14...v3.0.0-preview.15) (2020-08-11)


### Bug Fixes

* An exception in the OnSceneGUI caused the scale of the transformation to change unintentionally ([75413e0](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/75413e0e2cff42a85b73b33e17e0bb6344ecc8f6))

# [3.0.0-preview.14](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.13...v3.0.0-preview.14) (2020-08-11)


### Bug Fixes

* read-only properties in the inspector ([f012b23](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/f012b238d97aad3fdc3107b1f9a197de869c43e6))

# [3.0.0-preview.13](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.12...v3.0.0-preview.13) (2020-08-11)


### Bug Fixes

* Added CanvasRenderer as a required component ([a8950f6](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/a8950f65c817be04b0be222c9728c716fdd7c658))
* inspector is broken in Unity 2020.1 ([26c5395](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/26c5395a45ff00e99e46ee4aae85c51df6c3641f))


### Features

* update OSC to 1.0.0-preview.25 ([22e116e](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/22e116e11d3b8cf13b941e9a02a0ffce24e3e99f))

# [3.0.0-preview.12](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.11...v3.0.0-preview.12) (2020-08-11)


### Bug Fixes

* Profiler.BeginSample -> Profiler.EndSample if a canvas is disabled or a camera doesn't found ([4a0a5d1](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/4a0a5d13be68e38d5b2e225156740aed27c52d12))

# [3.0.0-preview.11](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.10...v3.0.0-preview.11) (2020-05-07)


### Bug Fixes

* If sprite is null, a null exception is thrown ([50c6e98](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/50c6e980ca37dda1bece5252162fa05ca3472ee8))

# [3.0.0-preview.10](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.9...v3.0.0-preview.10) (2020-04-30)


### Features

* add support for SpriteAtlas ([b31e325](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/b31e325bb1ef0856cb1ac4c4b0c4da0f1578b8ba))

# [3.0.0-preview.9](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.8...v3.0.0-preview.9) (2020-03-04)


### Bug Fixes

* fix displayed version in readme ([c29bbdd](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/c29bbddf8ad9a251d5f472b77cf85b3d432bba71))

# [3.0.0-preview.8](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.7...v3.0.0-preview.8) (2020-03-03)


### Bug Fixes

* abnormal Mesh Bounds with Particle Trails ([518a749](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/518a7497105a114a0f6b1782df0c35ba0aecfab2)), closes [#61](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/61)
* multiple UIParticleOverlayCamera in scene ([3f09395](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/3f093958b3353463d6c5bd29ef3338203d4e41d7)), closes [#73](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/73)

# [3.0.0-preview.7](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.6...v3.0.0-preview.7) (2020-03-02)


### Bug Fixes

* add package keywords ([49d8f3f](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/49d8f3fe4c76cf6bd2cd5b6134ee23134532da8e))
* fix sample path ([57ee210](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/57ee21005e114fdf186b5db55ca2b77b7b7c441a))

# [3.0.0-preview.6](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.5...v3.0.0-preview.6) (2020-02-21)


### Bug Fixes

* sample version ([ed18032](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/ed18032be43397debbd538cae258c226ebeeb2e9))

# [3.0.0-preview.5](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.4...v3.0.0-preview.5) (2020-02-21)


### Bug Fixes

* particles not visible if scale.z is 0 ([35718e0](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/35718e099acbb04fdadf131c7e4d2e6c3f4a1756)), closes [#64](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/64)

# [3.0.0-preview.4](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.3...v3.0.0-preview.4) (2020-02-18)


### Bug Fixes

* compile error in Unity 2019.1 or later ([28ca922](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/28ca922167afff3ef8341fa747968357d4487d1f)), closes [#70](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/70) [#71](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/71)

# [3.0.0-preview.3](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.2...v3.0.0-preview.3) (2020-02-17)


### Bug Fixes

* remove unnecessary scripts ([0a43740](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/0a4374099dc3151e7f1a3a24a6ce6c39a968e163))
* workaround for [#70](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/70) ([4bbcc33](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/4bbcc334abb7cd6db2897fad0bda219d5ea73530))

# [3.0.0-preview.2](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v3.0.0-preview.1...v3.0.0-preview.2) (2020-02-13)


### Bug Fixes

* compile error ([e2c5c7b](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/e2c5c7b05d1307877e2f37555d4845932d542930))

# [3.0.0-preview.1](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v2.3.0...v3.0.0-preview.1) (2020-02-12)


### Bug Fixes

* change the text in the inspector to make it more understandable. ([7ca0b6f](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/7ca0b6fa34c1168ef103992e1c69b68631b3bc60)), closes [#66](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/66)
* editor crashes when mesh is set to null when ParticleSystem.RenderMode=Mesh ([e5ebadd](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/e5ebadd84731716f82c63ac5ba3eb676720e3ad6)), closes [#69](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/69)
* getting massive errors on editor ([ef82fa8](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/ef82fa82a69894e643f0d257f99eb9177785f697)), closes [#67](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/67)
* heavy editor UI ([d3b470a](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/d3b470a2be3a21add9e126b357e46bdfaa6f16c8))
* remove a menu to add overlay camera ([f5d3b6e](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/f5d3b6edb5687c4d465992ef5c3c0d54f7b36d74))
* rotating the particle rect may cause out of bounds ([3439842](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/3439842119f334b50910c0a983e561944cc792a2)), closes [#55](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/55)
* scale will be decrease on editor ([0c59846](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/0c59846f11438b12caad04ae5d5b544a28883ea6))
* UI darker than normal when change to linear color space ([db4d8a7](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/db4d8a742ca36c8dd2de6936b9cf2912c72d4b9f)), closes [#57](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/57)


### Build System

* update develop environment ([9fcf169](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/9fcf169cd3ced519611b2ede7f98ad4d678027c6))


### Features

* add menu to import sample ([b8b1827](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/b8b18273185769235101da01f5bbadbac188e387))
* add samples test ([287b5cc](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/287b5cc832f2899796227520bda4d11ad8e4fae9))
* **editor:** add osc package (portable mode) ([6c7f880](https://github.com/mob-sakai/ParticleEffectForUGUI/commit/6c7f8804350112505949c5c296f9e0340877a3e8))


### BREAKING CHANGES

* update develop environment to Unity 2018.3.
Unity 2018.2 will continue to be supported.

# Changelog

## [v2.3.0](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v2.3.0) (2019-05-12)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v2.2.1...v2.3.0)

World simulation bug due to transform movement have been fixed

**Fixed bugs:**

- World simulation bug due to transform movement [\#47](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/47)

## [v2.2.1](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v2.2.1) (2019-02-26)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v2.2.0...v2.2.1)

**Fixed bugs:**

- v2.2.0 has 2 warnings [\#44](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/44)
- Disable ParticleSystemRenderer on reset [\#45](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/45)

## [v2.2.0](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v2.2.0) (2019-02-23)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v2.1.1...v2.2.0)

**Implemented enhancements:**

- Display warning when material does not support Mask [\#43](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/43)
- Support changing material property by AnimationClip [\#42](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/42)

**Fixed bugs:**

- UV Animation is not work. [\#41](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/41)

## [v2.1.1](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v2.1.1) (2019-02-15)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v2.1.0...v2.1.1)

## [v2.1.0](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v2.1.0) (2019-02-07)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v2.0.0...v2.1.0)

World simulation bug is fixed.  
![](https://user-images.githubusercontent.com/12690315/52386223-71a56000-2ac8-11e9-9cdb-93175d24febe.gif)

**Fixed bugs:**

- When moving the transform in world simulation mode, particles don't behave as expected [\#37](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/37)

## [v2.0.0](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v2.0.0) (2019-01-17)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v1.3.3...v2.0.0)

**Install UIParticle with Unity Package Manager!**

Find the manifest.json file in the Packages folder of your project and edit it to look like this:
```js
{
  "dependencies": {
    "com.coffee.ui-particle": "https://github.com/mob-sakai/ParticleEffectForUGUI.git#2.0.0",
    ...
  },
}
```
To update the package, change `#2.0.0` to the target version.

**Implemented enhancements:**

- Integrate with UnityPackageManager [\#30](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/30)

## [v1.3.3](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v1.3.3) (2019-01-16)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v1.3.2...v1.3.3)

**Fixed bugs:**

- On prefab edit mode, unnecessary UIParticleOverlayCamera is generated in the scene [\#35](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/35)
- With 'Screen Space - Camera' render mode, sorting is incorrect [\#34](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/34)

## [v1.3.2](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v1.3.2) (2018-12-29)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v1.3.1...v1.3.2)

**Implemented enhancements:**

- Use shared material during play mode [\#29](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/29)

**Fixed bugs:**

- Particle not showing on Android, while on editor it works  [\#31](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/31)

## [v1.3.1](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v1.3.1) (2018-12-24)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v1.3.0...v1.3.1)

**Fixed bugs:**

- OnSceneGUI has errors in Unity 2018.2 [\#27](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/27)
- Demo scene crashes in Unity 2018.2 [\#26](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/26)

## [v1.3.0](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v1.3.0) (2018-12-21)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v1.2.1...v1.3.0)

With Gizmo you can control the scaled Shape.  
![](https://user-images.githubusercontent.com/12690315/50343861-f31e4e80-056b-11e9-8f60-8bd0a8ff7adb.gif)

**Fixed bugs:**

- In overlay, particle size is too small [\#23](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/23)
- UIParticle.Scale does not affect the gizmo of shape module [\#21](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/21)

## [v1.2.1](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v1.2.1) (2018-12-13)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v1.2.0...v1.2.1)

**Fixed bugs:**

- Rect mask 2D doesn't work on WebGL [\#20](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/20)

## [v1.2.0](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v1.2.0) (2018-12-13)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v1.1.0...v1.2.0)

New scaling system solves the particle effect scaling problem in most cases.
* All ParticleSystem.ScalingModes are supported
* All Canvas.RenderModes are supported
* They look almost the same in all modes

New scaling system scales particle effect well even if you change the following parameters:
* Camera.FieldOfView
* CanvasScaler.MatchWidthOrHeight
* Canvas.PlaneDistance

![](https://user-images.githubusercontent.com/12690315/49866926-6c22f500-fe4c-11e8-8393-d5a546e9e2d3.gif)

**NOTE: If upgrading from v1.1.0, readjust the UIParticle.Scale property.**

**Implemented enhancements:**

- New scaling system [\#18](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/18)

**Fixed bugs:**

- Rect mask 2D doesn't work [\#17](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/17)
- Using prefab view will cause a lot of errors [\#16](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/16)
- Canvas.scaleFactor not take into account [\#15](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/15)

## [v1.1.0](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v1.1.0) (2018-11-28)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v1.0.0...v1.1.0)

Easily to use, easily to set up.

* Adjust the Scale property to change the size of the effect.  
![](https://user-images.githubusercontent.com/12690315/49148937-19c1de80-f34c-11e8-87fc-138192777540.gif)
* If your effect consists of multiple ParticleSystems, you can quickly set up UIParticles by clicking "Fix".
![](https://user-images.githubusercontent.com/12690315/49148942-1c243880-f34c-11e8-9cf5-d871d65c4dbe.png)

**Implemented enhancements:**

- Easy setup in editor [\#11](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/11)
- Add a scale property independent of transform [\#10](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/10)

**Fixed bugs:**

- Raycast blocking is unnecessary [\#12](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/12)

## [v1.0.0](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v1.0.0) (2018-07-13)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/v0.1.0...v1.0.0)

Let's use particle for your UI!  
UIParticle is use easy.  
The particle rendering is maskable and sortable, without Camera, RenderTexture or Canvas.  
![](https://user-images.githubusercontent.com/12690315/41771577-8da4b968-7650-11e8-9524-cd162c422d9d.gif)

**Implemented enhancements:**

- Supports sprites [\#5](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/5)
- Use Canvas.willRenderCanvases event instead of LateUpdate [\#4](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/4)

## [v0.1.0](https://github.com/mob-sakai/ParticleEffectForUGUI/tree/v0.1.0) (2018-06-22)

[Full Changelog](https://github.com/mob-sakai/ParticleEffectForUGUI/compare/6b89c14a5144e290e55d041bc0ad03756a113ae0...v0.1.0)

![](https://user-images.githubusercontent.com/12690315/41771577-8da4b968-7650-11e8-9524-cd162c422d9d.gif)

This plugin uses new APIs `MeshBake/MashTrailBake` (added with Unity 2018.2) to render particles by CanvasRenderer.  
You can mask and sort particles for uGUI without Camera, RenderTexture, Canvas.

**Implemented enhancements:**

- Bake particle mesh to render by CanvasRenderer [\#1](https://github.com/mob-sakai/ParticleEffectForUGUI/issues/1)



\* *This Changelog was automatically generated by [github_changelog_generator](https://github.com/github-changelog-generator/github-changelog-generator)*
