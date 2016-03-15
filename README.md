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

## Complex motion examples

### Parabola

```C#
g.MotionX().Velocity(6f);
g.MotionY().Velocity(18f).Accel(-0.98f);
```

![parabola](https://cloud.githubusercontent.com/assets/1482297/13764902/c2e1ba50-ea97-11e5-91ad-581e37cce268.gif)

## License

Copyright 2016 Oink Games, Inc. and other contributors.

Code licensed under the MIT License: http://opensource.org/licenses/MIT
