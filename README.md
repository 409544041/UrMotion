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
g.MotionX().Accel(0.3f).Delay(15f);
```

![delay](https://cloud.githubusercontent.com/assets/1482297/13766176/ffdc7ade-eaa2-11e5-92cf-407e565884b0.gif)

Finish velocity effect if it magnitude is less than 0.01f.
Then, destroy a GameObject.

```C#
g.MotionX().AccelByRatio(10f, 0.9f).LiveThreshold(0.01f).Then(() => Destroy(g));
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

## License

Copyright 2016 Oink Games, Inc. and other contributors.

Code licensed under the MIT License: http://opensource.org/licenses/MIT
