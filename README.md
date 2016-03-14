# A flexible motion engine for non time-based animation in Unity

UrMotion (Your motion) is a brand new simple & flexible motion engine for Unity.
It enables you to create non time-based complex animations on your script easy and fast.

## Features

### Simple & Lightweight

UrMotion is super simple. Core system (`MotionBehaviour.cs`) is about 100 lines code. Simple is powerful.

### Easy to use

```C#
// Move 3 units everyframe.
g.MotionX().Velocity(3f);
```

That's all.

### Fluent Syntax

```C#
// Move 3 units and accel 1 unit everyframe.
g.MotionX().Velocity(3f).Accel(1f);
```

### Unity friendly

UrMotion's design is completely focusing on Unity.
It works as a simple Unity component and follows a Unity execution flow.

## Setup

Simply copy a `UrMotion` directory to your Unity project. `UrMotion - Example` directory is not needed.

## Examples

Open a `UrMotion - Example/Scenes/Example.unity` scene. All code is written in `UrMotion - Example/Scripts/Example.cs`.
