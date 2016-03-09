using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	using Syntax = UrMotion.FluentSyntax;

	public static class MovementSyntax
	{
		public static MotionBehaviour<V> Sin<V, T>(this MotionBehaviour<V> self, T radius, float freq)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Add(Movement.Sin(Syntax.AsEnumerator<float,   T>(radius), freq, self.FrameRate)),
				(e) => e.Add(Movement.Sin(Syntax.AsEnumerator<Vector2, T>(radius), freq, self.FrameRate)),
				(e) => e.Add(Movement.Sin(Syntax.AsEnumerator<Vector3, T>(radius), freq, self.FrameRate)),
				(e) => e.Add(Movement.Sin(Syntax.AsEnumerator<Vector4, T>(radius), freq, self.FrameRate))
			);
			return self;
		}

		public static MotionBehaviour<V> Sin<V>(this MotionBehaviour<V> self, Func<V> radius, float freq)
		{
			return Sin<V, Func<V>>(self, radius, freq);
		}
	}
}