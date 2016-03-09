using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	public static class Velocity
	{
		public static IEnumerator<V> Constant<V>(V val)
		{
			return Source.Constant(val);
		}

		public static IEnumerator<float> Accel(IEnumerator<float> a)
		{
			var v = default(float);
			while (a.MoveNext()) {
				v += a.Current;
				yield return v;
			}
		}

		public static IEnumerator<Vector2> Accel(IEnumerator<Vector2> a)
		{
			var v = default(Vector2);
			while (a.MoveNext()) {
				v += a.Current;
				yield return v;
			}
		}

		public static IEnumerator<Vector3> Accel(IEnumerator<Vector3> a)
		{
			var v = default(Vector3);
			while (a.MoveNext()) {
				v += a.Current;
				yield return v;
			}
		}

		public static IEnumerator<Vector4> Accel(IEnumerator<Vector4> a)
		{
			var v = default(Vector4);
			while (a.MoveNext()) {
				v += a.Current;
				yield return v;
			}
		}
	}
}