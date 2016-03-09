using UnityEngine;
using System.Collections.Generic;

namespace UrMotion
{
	public static class Filter
	{
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
	}
}