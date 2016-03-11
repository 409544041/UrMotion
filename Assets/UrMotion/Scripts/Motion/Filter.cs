using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	public static class Filter
	{
		public static IEnumerator<V> Map<V>(IEnumerator<V> source, Func<V, V> map)
		{
			while (source.MoveNext()) {
				yield return map(source.Current);
			}
		}

		public static IEnumerator<V2> Map<V1, V2>(IEnumerator<V1> source, Func<V1, V2> map)
		{
			while (source.MoveNext()) {
				yield return map(source.Current);
			}
		}

		public static IEnumerator<float> Negate(IEnumerator<float> source)
		{
			while (source.MoveNext()) {
				yield return -source.Current;
			}
		}

		public static IEnumerator<Vector2> Negate(IEnumerator<Vector2> source)
		{
			while (source.MoveNext()) {
				yield return source.Current * -1f;
			}
		}

		public static IEnumerator<Vector3> Negate(IEnumerator<Vector3> source)
		{
			while (source.MoveNext()) {
				yield return source.Current * -1f;
			}
		}

		public static IEnumerator<Vector4> Negate(IEnumerator<Vector4> source)
		{
			while (source.MoveNext()) {
				yield return source.Current * -1f;
			}
		}

		public static IEnumerator<float> Offset(IEnumerator<float> source, IEnumerator<float> value)
		{
			while (source.MoveNext() && value.MoveNext()) {
				yield return source.Current + value.Current;
			}
		}

		public static IEnumerator<Vector2> Offset(IEnumerator<Vector2> source, IEnumerator<Vector2> value)
		{
			while (source.MoveNext() && value.MoveNext()) {
				yield return source.Current + value.Current;
			}
		}

		public static IEnumerator<Vector3> Offset(IEnumerator<Vector3> source, IEnumerator<Vector3> value)
		{
			while (source.MoveNext() && value.MoveNext()) {
				yield return source.Current + value.Current;
			}
		}

		public static IEnumerator<Vector4> Offset(IEnumerator<Vector4> source, IEnumerator<Vector4> value)
		{
			while (source.MoveNext() && value.MoveNext()) {
				yield return source.Current + value.Current;
			}
		}

		public static IEnumerator<float> Amplify(IEnumerator<float> source, IEnumerator<float> value)
		{
			while (source.MoveNext() && value.MoveNext()) {
				yield return source.Current * value.Current;
			}
		}

		public static IEnumerator<Vector2> Amplify(IEnumerator<Vector2> source, IEnumerator<float> value)
		{
			while (source.MoveNext() && value.MoveNext()) {
				yield return source.Current * value.Current;
			}
		}

		public static IEnumerator<Vector3> Amplify(IEnumerator<Vector3> source, IEnumerator<float> value)
		{
			while (source.MoveNext() && value.MoveNext()) {
				yield return source.Current * value.Current;
			}
		}

		public static IEnumerator<Vector4> Amplify(IEnumerator<Vector4> source, IEnumerator<float> value)
		{
			while (source.MoveNext() && value.MoveNext()) {
				yield return source.Current * value.Current;
			}
		}

		public static IEnumerator<V> Discrete<V>(IEnumerator<V> source, IEnumerator<float> interval)
		{
			while (source.MoveNext()) {
				var v = source.Current;
				var time = 0f;
				for (;;) {
					if (interval.MoveNext()) {
						if (time <= interval.Current) {
							yield return v;
						} else {
							break;
						}
					} else {
						yield break;
					}
					time += 1f;
				}
			}
		}

		public static IEnumerator<float> ToAngle(IEnumerator<Vector2> vector)
		{
			while (vector.MoveNext()) {
				var v = vector.Current;
				yield return Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
			}
		}

		public static IEnumerator<Vector3> ToAngle(IEnumerator<Vector3> vector)
		{
			while (vector.MoveNext()) {
				yield return Quaternion.LookRotation(vector.Current).eulerAngles;
			}
		}
	}
}