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

		public static MotionBehaviour<V> Cos<V, T>(this MotionBehaviour<V> self, T radius, float freq)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Add(Movement.Cos(Syntax.AsEnumerator<float,   T>(radius), freq, self.FrameRate)),
				(e) => e.Add(Movement.Cos(Syntax.AsEnumerator<Vector2, T>(radius), freq, self.FrameRate)),
				(e) => e.Add(Movement.Cos(Syntax.AsEnumerator<Vector3, T>(radius), freq, self.FrameRate)),
				(e) => e.Add(Movement.Cos(Syntax.AsEnumerator<Vector4, T>(radius), freq, self.FrameRate))
			);
			return self;
		}

		public static MotionBehaviour<Vector2> Circular<T>(this MotionBehaviour<Vector2> self, T radius, float speed)
		{
			self.Add(Movement.Circular(Syntax.AsEnumerator<float, T>(radius), speed, self.FrameRate));
			return self;
		}

		public static MotionBehaviour<Vector2> Lissajous<T1, T2>(this MotionBehaviour<Vector2> self, T1 A, T2 B, float a, float b, float delta)
		{
			self.Add(Movement.Lissajous(Syntax.AsEnumerator<float, T1>(A), Syntax.AsEnumerator<float, T2>(B), a, b, delta, self.FrameRate));
			return self;
		}

		public static MotionBehaviour<Vector2> Cycloid<T1, T2>(this MotionBehaviour<Vector2> self, T1 A, T2 B, float rm, float speed)
		{
			self.Add(Movement.Cycloid(Syntax.AsEnumerator<float, T1>(A), Syntax.AsEnumerator<float, T2>(B), rm , speed, self.FrameRate));
			return self;
		}

		public static MotionBehaviour<Vector2> Epicycloid<T1, T2>(this MotionBehaviour<Vector2> self, T1 A, T2 B, float rc, float rm, float speed)
		{
			self.Add(Movement.Epicycloid(Syntax.AsEnumerator<float, T1>(A), Syntax.AsEnumerator<float, T2>(B), rc, rm , speed, self.FrameRate));
			return self;
		}

		public static MotionBehaviour<Vector2> Hypocycloid<T1, T2>(this MotionBehaviour<Vector2> self, T1 A, T2 B, float rc, float rm, float speed)
		{
			self.Add(Movement.Hypocycloid(Syntax.AsEnumerator<float, T1>(A), Syntax.AsEnumerator<float, T2>(B), rc, rm , speed, self.FrameRate));
			return self;
		}

		public static MotionBehaviour<V> Sin<V>(this MotionBehaviour<V> self, Func<V> radius, float freq)
		{
			return Sin<V, Func<V>>(self, radius, freq);
		}

		public static MotionBehaviour<V> Cos<V>(this MotionBehaviour<V> self, Func<V> radius, float freq)
		{
			return Cos<V, Func<V>>(self, radius, freq);
		}

		public static MotionBehaviour<Vector2> Circular(this MotionBehaviour<Vector2> self, Func<float> radius, float speed)
		{
			return Circular<Func<float>>(self, radius, speed);
		}

		public static MotionBehaviour<Vector2> Lissajous(this MotionBehaviour<Vector2> self, Func<float> A, Func<float> B, float a, float b, float delta)
		{
			return Lissajous<Func<float>, Func<float>>(self, A, B, a, b, delta);
		}

		public static MotionBehaviour<Vector2> Cycloid(this MotionBehaviour<Vector2> self, Func<float> A, Func<float> B, float rm, float speed)
		{
			return Cycloid<Func<float>, Func<float>>(self, A, B, rm, speed);
		}

		public static MotionBehaviour<Vector2> Epicycloid(this MotionBehaviour<Vector2> self, Func<float> A, Func<float> B, float rc, float rm, float speed)
		{
			return Epicycloid<Func<float>, Func<float>>(self, A, B, rc, rm, speed);
		}

		public static MotionBehaviour<Vector2> Hypocycloid(this MotionBehaviour<Vector2> self, Func<float> A, Func<float> B, float rc, float rm, float speed)
		{
			return Hypocycloid<Func<float>, Func<float>>(self, A, B, rc, rm, speed);
		}
	}
}