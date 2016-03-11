using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	public static class Movement
	{
		public static IEnumerator<float> Sin(IEnumerator<float> radius, float freq, float fps)
		{
			return Move(Source.Sin(radius, freq, fps));
		}

		public static IEnumerator<Vector2> Sin(IEnumerator<Vector2> radius, float freq, float fps)
		{
			return Move(Source.Sin(radius, freq, fps));
		}

		public static IEnumerator<Vector3> Sin(IEnumerator<Vector3> radius, float freq, float fps)
		{
			return Move(Source.Sin(radius, freq, fps));
		}

		public static IEnumerator<Vector4> Sin(IEnumerator<Vector4> radius, float freq, float fps)
		{
			return Move(Source.Sin(radius, freq, fps));
		}

		public static IEnumerator<float> Cos(IEnumerator<float> radius, float freq, float fps)
		{
			return Move(Source.Cos(radius, freq, fps));
		}

		public static IEnumerator<Vector2> Cos(IEnumerator<Vector2> radius, float freq, float fps)
		{
			return Move(Source.Cos(radius, freq, fps));
		}

		public static IEnumerator<Vector3> Cos(IEnumerator<Vector3> radius, float freq, float fps)
		{
			return Move(Source.Cos(radius, freq, fps));
		}

		public static IEnumerator<Vector4> Cos(IEnumerator<Vector4> radius, float freq, float fps)
		{
			return Move(Source.Cos(radius, freq, fps));
		}

		public static IEnumerator<Vector2> Circular(IEnumerator<float> radius, float speed, float fps)
		{
			return Move(Source.Circular(radius, speed, fps));
		}

		public static IEnumerator<Vector2> Lissajous(IEnumerator<float> A, IEnumerator<float> B, float a, float b, float delta, float fps)
		{
			return Move(Source.Lissajous(A, B, a, b, delta, fps));
		}

		public static IEnumerator<Vector2> Cycloid(IEnumerator<float> A, IEnumerator<float> B, float rm, float speed, float fps)
		{
			return Move(Source.Cycloid(A, B, rm, speed, fps));
		}

		public static IEnumerator<Vector2> Epicycloid(IEnumerator<float> A, IEnumerator<float> B, float rc, float rm, float speed, float fps)
		{
			return Move(Source.Epicycloid(A, B, rc, rm, speed, fps));
		}

		public static IEnumerator<Vector2> Hypocycloid(IEnumerator<float> A, IEnumerator<float> B, float rc, float rm, float speed, float fps)
		{
			return Move(Source.Hypocycloid(A, B, rc, rm, speed, fps));
		}

		static IEnumerator<float> Move(IEnumerator<float> movement)
		{
			var v = default(float);
			while (movement.MoveNext()) {
				var c = movement.Current;
				yield return c - v;
				v = c;
			}
		}

		static IEnumerator<Vector2> Move(IEnumerator<Vector2> movement)
		{
			var v = default(Vector2);
			while (movement.MoveNext()) {
				var c = movement.Current;
				yield return c - v;
				v = c;
			}
		}

		static IEnumerator<Vector3> Move(IEnumerator<Vector3> movement)
		{
			var v = default(Vector3);
			while (movement.MoveNext()) {
				var c = movement.Current;
				yield return c - v;
				v = c;
			}
		}

		static IEnumerator<Vector4> Move(IEnumerator<Vector4> movement)
		{
			var v = default(Vector4);
			while (movement.MoveNext()) {
				var c = movement.Current;
				yield return c - v;
				v = c;
			}
		}
	}
}