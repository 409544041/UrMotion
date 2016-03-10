using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	using Syntax = UrMotion.FluentSyntax;

	public static class AimingSyntax
	{
		public static MotionBehaviour<V> AimAt<V, T1, T2>(this MotionBehaviour<V> self, T1 destination, T2 speed)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Add(Aiming.AimAt(Syntax.AsEnumerator<float,   T1>(destination), Syntax.AsEnumerator<float, T2>(speed), e.ValueEnumerator)),
				(e) => e.Add(Aiming.AimAt(Syntax.AsEnumerator<Vector2, T1>(destination), Syntax.AsEnumerator<float, T2>(speed), e.ValueEnumerator)),
				(e) => e.Add(Aiming.AimAt(Syntax.AsEnumerator<Vector3, T1>(destination), Syntax.AsEnumerator<float, T2>(speed), e.ValueEnumerator)),
				(e) => e.Add(Aiming.AimAt(Syntax.AsEnumerator<Vector4, T1>(destination), Syntax.AsEnumerator<float, T2>(speed), e.ValueEnumerator))
			);
			return self;
		}

		public static MotionBehaviour<V> AimVelocity<V, T1, T2>(this MotionBehaviour<V> self, T1 destination, T2 speed)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Add(Aiming.AimVelocity(Syntax.AsEnumerator<float,   T1>(destination), Syntax.AsEnumerator<float,   T2>(speed), e.ValueEnumerator)),
				(e) => e.Add(Aiming.AimVelocity(Syntax.AsEnumerator<Vector2, T1>(destination), Syntax.AsEnumerator<Vector2, T2>(speed), e.ValueEnumerator)),
				(e) => e.Add(Aiming.AimVelocity(Syntax.AsEnumerator<Vector3, T1>(destination), Syntax.AsEnumerator<Vector3, T2>(speed), e.ValueEnumerator)),
				(e) => e.Add(Aiming.AimVelocity(Syntax.AsEnumerator<Vector4, T1>(destination), Syntax.AsEnumerator<Vector4, T2>(speed), e.ValueEnumerator))
			);
			return self;
		}

		public static MotionBehaviour<V> AimAt<V>(this MotionBehaviour<V> self, Func<V> destination, Func<float> speed)
		{
			return AimAt<V>(self, destination, speed);
		}

		public static MotionBehaviour<V> AimVelocity<V>(this MotionBehaviour<V> self, Func<V> destination, Func<V> speed)
		{
			return AimVelocity<V>(self, destination, speed);
		}
	}
}