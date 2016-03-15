using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	using Syntax = UrMotion.FluentSyntax;

	public static class NoiseSyntax
	{
		public static MotionBehaviour<V> Perlin<V>(this MotionBehaviour<V> self, V speed)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Add(Noise.Perlin((float  )(object)speed, self.FrameRate)),
				(e) => e.Add(Noise.Perlin((Vector2)(object)speed, self.FrameRate)),
				(e) => e.Add(Noise.Perlin((Vector3)(object)speed, self.FrameRate)),
				(e) => e.Add(Noise.Perlin((Vector4)(object)speed, self.FrameRate))
			);
			return self;
		}
		public static MotionBehaviour<V> Perlin<V>(this MotionBehaviour<V> self, V offset, V speed)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Add(Noise.PerlinWith((float  )(object)offset, (float  )(object)speed, self.FrameRate)),
				(e) => e.Add(Noise.PerlinWith((Vector2)(object)offset, (Vector2)(object)speed, self.FrameRate)),
				(e) => e.Add(Noise.PerlinWith((Vector3)(object)offset, (Vector3)(object)speed, self.FrameRate)),
				(e) => e.Add(Noise.PerlinWith((Vector4)(object)offset, (Vector4)(object)speed, self.FrameRate))
			);
			return self;
		}
	}
}