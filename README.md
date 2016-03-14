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

![accel_with_init_2](https://cloud.githubusercontent.com/assets/1482297/13746251/ddbf4aac-ea35-11e5-9bf4-b7b45b8d2106.gif)

```C#
g.MotionP().Velocity(new Vector2(6f, 18f)).Accel(new Vector2(0f, -0.98f));
```

![accel_with_init_3](https://cloud.githubusercontent.com/assets/1482297/13746448/dd96ab46-ea36-11e5-8674-29d1d159c0b9.gif)

## License

Copyright 2016 Oink Games, Inc. and other contributors.

Code licensed under the MIT License: http://opensource.org/licenses/MIT
