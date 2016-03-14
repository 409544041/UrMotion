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
g.MotionXY().Velocity(new Vector2(3f, 2f));
```

![velocity_xy](https://cloud.githubusercontent.com/assets/1482297/13745885/ce749d06-ea33-11e5-8848-dbd05516affa.gif)

## License

Copyright 2016 Oink Games, Inc. and other contributors.

Code licensed under the MIT License: http://opensource.org/licenses/MIT
