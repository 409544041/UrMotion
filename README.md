# A flexible motion engine for non time-based animation in Unity

UrMotion (Your motion) is a brand new simple & flexible motion engine for Unity.
It enables you to create non time-based complex animations on your script easy and fast.

To start using UrMotion, copy `Assets/UrMotion` directoy to your project and write `using UrMotion;` in your code.

```C#
using UnityEngine;
using System.Collections;
using UrMotion;
```

## Examples

### Simply uniform move

```C#
g.MotionX().Velocity(3f);
```

![velocity_x](https://cloud.githubusercontent.com/assets/1482297/13745657/a492e7fa-ea32-11e5-98dd-22f61cdd7617.gif)

### Simply uniform move (Moving Y)

```C#
g.MotionY().Velocity(3f);
```

![velocity_y](https://cloud.githubusercontent.com/assets/1482297/13745812/6cbe3ffe-ea33-11e5-8cf1-6b1a64b02502.gif)

### Simply uniform move (Moving X & Y)

```C#
g.MotionP().Velocity(new Vector2(3f, 2f));
```

![velocity_xy](https://cloud.githubusercontent.com/assets/1482297/13745885/ce749d06-ea33-11e5-8848-dbd05516affa.gif)

### Accel move

```C#
g.MotionX().Accel(0.3f);
```

![accel_x](https://cloud.githubusercontent.com/assets/1482297/13746040/a856bd6a-ea34-11e5-8682-1c03d62dde29.gif)

### Accel move with initial speed

```C#
g.MotionX().Velocity(1f).Accel(0.3f);
```

![accel_x_with_init](https://cloud.githubusercontent.com/assets/1482297/13746163/4f3dc79a-ea35-11e5-8e00-5126c8e1e9ab.gif)

```C#
g.MotionX().Velocity(-6f).Accel(0.3f);
```

![accel_with_init_2](https://cloud.githubusercontent.com/assets/1482297/13764927/0e84f5d0-ea98-11e5-9206-9fef6dcb1c24.gif)

### Accel by ratio

```C#
g.MotionX().AccelByRatio(10f, 0.9f);
```

![accel_by_ratio](https://cloud.githubusercontent.com/assets/1482297/13765144/babeb15a-ea99-11e5-9eb0-7dd14b8e1482.gif)

### Sin move

```C#
g.MotionX().Sin(83f, 0.5f);
```

![sin](https://cloud.githubusercontent.com/assets/1482297/13766403/e5b9d0dc-eaa4-11e5-8e6d-8b7810213f53.gif)

### Circular move

```C#
g.MotionP().Circular(83f, 0.5f);
```

![circular](https://cloud.githubusercontent.com/assets/1482297/13766625/ef8fea72-eaa6-11e5-9d8b-3b39b9733590.gif)

### Lissajous move

```C#
g.MotionP().Lissajous(83f, 51f, 0.6f, 1.2f, 0f);
```

![lissajous](https://cloud.githubusercontent.com/assets/1482297/13766843/d274a156-eaa8-11e5-887e-fbf4a3f502b3.gif)

### Aiming with uniform move

An aiming method produce a velocity that makes a GameObject go toward the specified position.

```C#
g.MotionP().AimAt(p, 10f);
```

![aim](https://cloud.githubusercontent.com/assets/1482297/13769120/6018c26e-eac0-11e5-8bdf-45400aef0136.gif)

### Aiming with common ratio

```C#
g.MotionP().AimRatioAt(p, 0.15f);
```

![aim_ratio](https://cloud.githubusercontent.com/assets/1482297/13769156/b445e3a8-eac0-11e5-9437-a498f5efed44.gif)

### Aiming with spring move

```C#
g.MotionP().AimSpringAt(p, 0.15f, 0.8f);
```

![aim_spring](https://cloud.githubusercontent.com/assets/1482297/13769261/98ecd9ee-eac1-11e5-88d5-17f898f569bd.gif)

### Aiming with exponential interpolation

```C#
g.MotionP().AimExpoAt(p, 0.15f);
```

![aim_expo](https://cloud.githubusercontent.com/assets/1482297/13769301/e35d8cda-eac1-11e5-8a2c-0a37af14768b.gif)

### Aiming with critically damped spring smoothing

```C#
g.MotionP().AimCriticalDampingAt(p, 0.15f);
```

![aim_critical](https://cloud.githubusercontent.com/assets/1482297/13769357/4aac3f44-eac2-11e5-914d-5cba808441b1.gif)

### Perlin noise

```C#
g.MotionP().Perlin(new Vector2(0.4f, 0.8f)).AmplifyComponents(new Vector2(3f, 2f));
```

![perlin](https://cloud.githubusercontent.com/assets/1482297/13772583/4a0903e0-ead8-11e5-82a5-e15678af3283.gif)

### Fractional brownian motion

```C#
g.MotionP().Fbm(new Vector2(0.4f, 0.8f), 3).AmplifyComponents(new Vector2(3f, 2f));
```

![fbm](https://cloud.githubusercontent.com/assets/1482297/13772542/162a7c70-ead8-11e5-9584-e2a386352ce8.gif)

### Timed parameter

Change velocity by time with sin curve.

```C#
g.MotionX().Velocity(Source.Float.Sin(2f, 1f).Offset(2f));
```

![velocity_sin](https://cloud.githubusercontent.com/assets/1482297/13766518/c7b454da-eaa5-11e5-903f-9e602c03078d.gif)

Change radius by time with sin curve.

```C#
g.MotionX().Sin(Source.Float.Sin(51f, 0.5f).Offset(51f), 1f);
```

![radius_sin](https://cloud.githubusercontent.com/assets/1482297/13766584/76bee0ee-eaa6-11e5-9926-cff56378bf4b.gif)

### Custom parameter

You can use any of the following types as a motion parameter.

 * `V`
 * `IEnumerator<V>`
 * `IEnumerable<V>`
 * `Func<V>`

`V` is: `float`, `Vector2`, `Vector3` or `Vector4`

```C#
g.MotionX().Velocity(() => Random.Range(-10f, 10f));
```

![own_function](https://cloud.githubusercontent.com/assets/1482297/13768846/981ffe28-eabd-11e5-84dd-49778119e2ac.gif)

### Lifetime control

Finish velocity effect after 15fr.

```C#
g.MotionX().Accel(0.3f).Lifetime(15f);
```

![lifetime](https://cloud.githubusercontent.com/assets/1482297/13766138/a8bc5fc6-eaa2-11e5-860d-2dc673629edd.gif)

Start velocity effect after 15fr.

```C#
g.MotionX().Accel(0.3f).StartDelay(15f);
```

![delay](https://cloud.githubusercontent.com/assets/1482297/13766176/ffdc7ade-eaa2-11e5-92cf-407e565884b0.gif)

Finish velocity effect if it magnitude is less than 0.01f.
Then, destroy a GameObject.

```C#
g.MotionX().AccelByRatio(10f, 0.9f).LiveThreshold(0.01f).Next(() => Destroy(g));
```

![complete_velocity](https://cloud.githubusercontent.com/assets/1482297/13765840/5bfe617c-eaa0-11e5-87ac-8572d7a771c4.gif)

## Complex motion examples

### Parabola

```C#
g.MotionX().Velocity(6f);
g.MotionY().Velocity(18f).Accel(-0.98f);
```

![parabola](https://cloud.githubusercontent.com/assets/1482297/13764902/c2e1ba50-ea97-11e5-91ad-581e37cce268.gif)

### Spiral

```C#
g.MotionP().Circular(Source.Float.Sin(51f, 0.5f).Offset(51f), 2f);
```

![spiral](https://cloud.githubusercontent.com/assets/1482297/13766722/d051baea-eaa7-11e5-90c2-e82e12a6051e.gif)

### Lissajous + Lissajous

```C#
g.MotionP().Lissajous(83f, 51f, 0.6f, 1.2f, 0f).Lissajous(24f, 32f, 2.4f, 0.8f, 0f);
```

![lissajous lissajous](https://cloud.githubusercontent.com/assets/1482297/13766920/576e4542-eaa9-11e5-8497-71bda0f558ed.gif)

### Lissajous with directon

```C#
var vel = default(IEnumerator<Vector2>);
g.MotionP().Lissajous(83f, 51f, 0.6f, 1.2f, 0f).Capture(out vel);
g.MotionR().AimRatioAt(vel.ToAngle().Offset(-90f), 1f);
```

![lissajous direction](https://cloud.githubusercontent.com/assets/1482297/13767022/36d96914-eaaa-11e5-9bde-2d2ecb559a7c.gif)

### Floating scaling

```C#
g.MotionS().AccelByRatio(Vector2.one * 0.4f, 0.85f).Sin(Vector2.one * 0.5f, 0.5f);
```

![floating_scaling](https://cloud.githubusercontent.com/assets/1482297/13767235/d3f350f6-eaab-11e5-9045-ba38b9d74370.gif)

### Aiming + Ciruclular move

```C#
var vel = default(IEnumerator<Vector2>);
var m = g.MotionP();
m.AimSpringAt(p, 0.1f, 0.45f).Capture(out vel);
m.Circular(vel.Magnitude().Amplify(2f), 2f);
```

![aim circular](https://cloud.githubusercontent.com/assets/1482297/13769818/e2d947c8-eac5-11e5-851f-095265aeb32b.gif)

### Scaling by velocity

```C#
var vel = default(IEnumerator<Vector2>);
g.MotionP().AimExpoAt(p, 0.15f).Capture(out vel);
g.MotionS().AimSpringAt(vel.Magnitude().Amplify(0.075f).Offset(1f).ToVector2(), 0.12f, 0.7f);
```

![scaling_by_velocity](https://cloud.githubusercontent.com/assets/1482297/13769616/5fab509a-eac4-11e5-9b41-5c83567f1e97.gif)

### Circular + Noise

```C#
g.MotionP().Circular(83f, 0.25f).Fbm(new Vector2(2f, 3f), 3).Amplify(6f);
```

![circular noise](https://cloud.githubusercontent.com/assets/1482297/13773205/75218414-eadb-11e5-9da0-583d0deea74c.gif)

### Follow move

```C#
Func<Vector2> p = () => GetMousePosition();
g.MotionP().AimCriticalDampingAt(p, 0.8f);
```

![follow](https://cloud.githubusercontent.com/assets/1482297/13770186/ae3889d6-eac8-11e5-93df-98c5a1d0082e.gif)

### Follow + Circular move

```C#
Func<Vector2> p = () => GetMousePosition();
g.MotionP().AimCriticalDampingAt(p, 0.8f).Circular(83f, 1.5f);
```

![follow circular](https://cloud.githubusercontent.com/assets/1482297/13771198/90db5484-eacf-11e5-932e-798d9905147e.gif)

### Follow + Follow + Follow

```C#
System.Func<Vector2> gp = () => new Vector2(g.transform.localPosition.x, g.transform.localPosition.y);
g.MotionP().AimCriticalDampingAt(p, 0.8f);
f1.MotionP().AimCriticalDampingAt(gp, 0.3f).StartDelay(6f).AccelByRatio(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)) * 20f, 0.9f);
f2.MotionP().AimCriticalDampingAt(gp, 0.2f).StartDelay(9f).AccelByRatio(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)) * 15f, 0.9f);
```

![follow follow](https://cloud.githubusercontent.com/assets/1482297/13773012/7e0ec5d8-eada-11e5-8d72-6a59e3084cc0.gif)

### Aiming + Noise

```C#
var vel = default(IEnumerator<Vector2>);
var m = g.MotionP();
m.AimSpringAt(p, 0.1f, 0.45f).Capture(out vel);
m.Perlin(new Vector2(7f, 11f)).Amplify(vel.Magnitude().Amplify(1.2f));
```

![aim noise](https://cloud.githubusercontent.com/assets/1482297/13773530/fced7438-eadc-11e5-81f9-e390d8e7fab9.gif)

### Spiral #2

```C#
for (var i = 0; i < 12; ++i) {
	g = GameObject.Instantiate(prefab);
	g.transform.SetParent(prefab.transform.parent);
	g.transform.localPosition = Vector3.zero;
	g.transform.localScale = Vector3.one;

	var angle = 30f * i;
	var radius = Velocity.AccelByRatio(218f, Source.Constant(0.92f)).Offset(83f);
	var speed = Velocity.AccelByRatio(0.75f, Source.Constant(0.94f)).Offset(0.01f);
	g.MotionP().Circular(radius, speed).Angle(angle).Fbm(new Vector2(0f, 1f), 3).AmplifyComponents(new Vector2(0f, 0.3f));
}
```

![spiral_2](https://cloud.githubusercontent.com/assets/1482297/13800153/b9fa493e-eb69-11e5-97ec-3069291197b3.gif)

## License

Copyright 2016 Oink Games, Inc. and other contributors.

Code licensed under the MIT License: http://opensource.org/licenses/MIT
