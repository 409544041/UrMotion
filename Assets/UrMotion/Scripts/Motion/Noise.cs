using UnityEngine;
using System.Collections.Generic;

namespace UrMotion
{
	using P = Klak.Math.Perlin;

	public static class Noise
	{
		public static IEnumerator<float> Perlin(float speed, float fps = 0f)
		{
			return PerlinWith(Random.Range(-10000f, 0f), speed, fps);
		}

		public static IEnumerator<Vector2> Perlin(Vector2 speed, float fps = 0f)
		{
			return PerlinWith(new Vector2(Random.Range(-10000f, 0f), Random.Range(-10000f, 0f)), speed, fps);
		}

		public static IEnumerator<Vector3> Perlin(Vector3 speed, float fps = 0f)
		{
			return PerlinWith(new Vector3(Random.Range(-10000f, 0f), Random.Range(-10000f, 0f), Random.Range(-10000f, 0f)), speed, fps);
		}

		public static IEnumerator<Vector4> Perlin(Vector4 speed, float fps = 0f)
		{
			return PerlinWith(new Vector4(Random.Range(-10000f, 0f), Random.Range(-10000f, 0f), Random.Range(-10000f, 0f), Random.Range(-10000f, 0f)), speed, fps);
		}

		public static IEnumerator<float> PerlinWith(float offset, float speed, float fps = 0f)
		{
			Source.ValidateFrameRate(ref fps);
			var f = 0f;
			for (;;) {
				var t = offset + (f / fps) * speed;
				yield return P.Noise(t);
				f += 1.0f;
			}
		}

		public static IEnumerator<Vector2> PerlinWith(Vector2 offset, Vector2 speed, float fps = 0f)
		{
			Source.ValidateFrameRate(ref fps);
			var f = 0f;
			for (;;) {
				var t = offset + (f / fps) * speed;
				yield return new Vector2(P.Noise(t.x), P.Noise(t.y));
				f += 1.0f;
			}
		}

		public static IEnumerator<Vector3> PerlinWith(Vector3 offset, Vector3 speed, float fps = 0f)
		{
			Source.ValidateFrameRate(ref fps);
			var f = 0f;
			for (;;) {
				var t = offset + (f / fps) * speed;
				yield return new Vector3(P.Noise(t.x), P.Noise(t.y), P.Noise(t.z));
				f += 1.0f;
			}
		}

		public static IEnumerator<Vector4> PerlinWith(Vector4 offset, Vector4 speed, float fps = 0f)
		{
			Source.ValidateFrameRate(ref fps);
			var f = 0f;
			for (;;) {
				var t = offset + (f / fps) * speed;
				yield return new Vector4(P.Noise(t.x), P.Noise(t.y), P.Noise(t.z), P.Noise(t.w));
				f += 1.0f;
			}
		}
	}
}