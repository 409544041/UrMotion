using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	using Syntax = UrMotion.FluentSyntax;

	public static class SourceSyntax
	{
		public static IEnumerator<V> Sin<V, T>(this Source.SourceDimension<V> self, T radius, float freq, float fps = 0f)
		{
			var res = default(IEnumerator<V>);
			Syntax.Resolve<V>(
				() => res = Source.Sin(Syntax.AsEnumerator<float,   T>(radius), freq, fps) as IEnumerator<V>,
				() => res = Source.Sin(Syntax.AsEnumerator<Vector2, T>(radius), freq, fps) as IEnumerator<V>,
				() => res = Source.Sin(Syntax.AsEnumerator<Vector3, T>(radius), freq, fps) as IEnumerator<V>,
				() => res = Source.Sin(Syntax.AsEnumerator<Vector4, T>(radius), freq, fps) as IEnumerator<V>
			);
			return res;
		}

		public static IEnumerator<V> Cos<V, T>(this Source.SourceDimension<V> self, T radius, float freq, float fps = 0f)
		{
			var res = default(IEnumerator<V>);
			Syntax.Resolve<V>(
				() => res = Source.Cos(Syntax.AsEnumerator<float,   T>(radius), freq, fps) as IEnumerator<V>,
				() => res = Source.Cos(Syntax.AsEnumerator<Vector2, T>(radius), freq, fps) as IEnumerator<V>,
				() => res = Source.Cos(Syntax.AsEnumerator<Vector3, T>(radius), freq, fps) as IEnumerator<V>,
				() => res = Source.Cos(Syntax.AsEnumerator<Vector4, T>(radius), freq, fps) as IEnumerator<V>
			);
			return res;
		}

		public static IEnumerator<Vector2> Circular<T>(this Source.SourceDimension<Vector2> self, T radius, float speed, float fps = 0f)
		{
			return Source.Circular(Syntax.AsEnumerator<float, T>(radius), speed, fps);
		}

		public static IEnumerator<Vector2> Lissajous<T1, T2>(this Source.SourceDimension<Vector2> self, T1 A, T2 B, float a, float b, float delta, float fps = 0f)
		{
			return Source.Lissajous(Syntax.AsEnumerator<float, T1>(A), Syntax.AsEnumerator<float, T2>(B), a, b, delta, fps);
		}

		public static IEnumerator<Vector2> Cycloid<T1, T2>(this Source.SourceDimension<Vector2> self, T1 A, T2 B, float rm, float speed, float fps = 0f)
		{
			return Source.Cycloid(Syntax.AsEnumerator<float, T1>(A), Syntax.AsEnumerator<float, T2>(B), rm, speed, fps);
		}

		public static IEnumerator<Vector2> Epicycloid<T1, T2>(this Source.SourceDimension<Vector2> self, T1 A, T2 B, float rc, float rm, float speed, float fps = 0f)
		{
			return Source.Epicycloid(Syntax.AsEnumerator<float, T1>(A), Syntax.AsEnumerator<float, T2>(B), rc, rm, speed, fps);
		}

		public static IEnumerator<Vector2> Hypocycloid<T1, T2>(this Source.SourceDimension<Vector2> self, T1 A, T2 B, float rc, float rm, float speed, float fps = 0f)
		{
			return Source.Hypocycloid(Syntax.AsEnumerator<float, T1>(A), Syntax.AsEnumerator<float, T2>(B), rc, rm, speed, fps);
		}
	}
}