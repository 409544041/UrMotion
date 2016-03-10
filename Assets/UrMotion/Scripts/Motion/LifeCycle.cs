using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	public static class LifeCycle
	{
		public static IEnumerator<V> Lifetime<V>(IEnumerator<V> source, IEnumerator<float> period)
		{
			var time = 0f;
			while (source.MoveNext() && period.MoveNext()) {
				if (time >= period.Current) {
					yield break;
				}
				yield return source.Current;
				time += 1f;
			}
		}

		public static IEnumerator<V> Delay<V>(IEnumerator<V> source, IEnumerator<float> delay)
		{
			var time = 0f;
			for (;;) {
				if (delay.MoveNext()) {
					if (time >= delay.Current) {
						break;
					}
				} else {
					yield break;
				}
				yield return default(V);
				time += 1f;
			}
			while (source.MoveNext()) {
				yield return source.Current;
			}
		}
		
		public static IEnumerator<float> Threshold(IEnumerator<float> source, IEnumerator<float> threshold)
		{
			while (source.MoveNext() && threshold.MoveNext()) {
				var val = source.Current;
				var th = threshold.Current;
				if (val < th) {
					yield break;
				} else {
					yield return val;
				}
			}
		}

		public static IEnumerator<Vector2> Threshold(IEnumerator<Vector2> source, IEnumerator<float> threshold)
		{
			while (source.MoveNext() && threshold.MoveNext()) {
				var val = source.Current;
				var th = threshold.Current;
				if (val.sqrMagnitude < th * th) {
					yield break;
				} else {
					yield return val;
				}
			}
		}

		public static IEnumerator<Vector3> Threshold(IEnumerator<Vector3> source, IEnumerator<float> threshold)
		{
			while (source.MoveNext() && threshold.MoveNext()) {
				var val = source.Current;
				var th = threshold.Current;
				if (val.sqrMagnitude < th * th) {
					yield break;
				} else {
					yield return val;
				}
			}
		}

		public static IEnumerator<Vector4> Threshold(IEnumerator<Vector4> source, IEnumerator<float> threshold)
		{
			while (source.MoveNext() && threshold.MoveNext()) {
				var val = source.Current;
				var th = threshold.Current;
				if (val.sqrMagnitude < th * th) {
					yield break;
				} else {
					yield return val;
				}
			}
		}
	}
}