using UnityEngine;
using System;

namespace UrMotion
{
	using Vel = UrMotion.Velocity;
	using Syntax = UrMotion.FluentSyntax;

	public static class VelocitySyntax
	{
		public static MotionBehaviour<V> Velocity<V, T>(this MotionBehaviour<V> self, T source)
		{
			self.Add(Syntax.AsEnumerator<V, T>(source));
			return self;
		}

		public static MotionBehaviour<V> Accel<V, T>(this MotionBehaviour<V> self, T accel)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Add(Vel.Accel(Syntax.AsEnumerator<float,   T>(accel))),
				(e) => e.Add(Vel.Accel(Syntax.AsEnumerator<Vector2, T>(accel))),
				(e) => e.Add(Vel.Accel(Syntax.AsEnumerator<Vector3, T>(accel))),
				(e) => e.Add(Vel.Accel(Syntax.AsEnumerator<Vector4, T>(accel)))
			);
			return self;
		}

		public static MotionBehaviour<V> Velocity<V>(this MotionBehaviour<V> self, Func<V> source)
		{
			return Velocity<V, Func<V>>(self, source);
		}

		public static MotionBehaviour<V> Accel<V>(this MotionBehaviour<V> self, Func<V> accel)
		{
			return Accel<V, Func<V>>(self, accel);
		}
	}
}