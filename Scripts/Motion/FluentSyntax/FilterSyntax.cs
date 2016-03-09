using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	using Syntax = UrMotion.FluentSyntax;

	public static class FilterSyntax
	{
		public static MotionBehaviour<V> Offset<V, T>(this MotionBehaviour<V> self, T value)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Wrap((v) => Filter.Offset(v, Syntax.AsEnumerator<float,   T>(value))),
				(e) => e.Wrap((v) => Filter.Offset(v, Syntax.AsEnumerator<Vector2, T>(value))),
				(e) => e.Wrap((v) => Filter.Offset(v, Syntax.AsEnumerator<Vector3, T>(value))),
				(e) => e.Wrap((v) => Filter.Offset(v, Syntax.AsEnumerator<Vector4, T>(value)))
			);
			return self;
		}

		public static MotionBehaviour<V> Amplify<V, T>(this MotionBehaviour<V> self, T value)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Wrap((v) => Filter.Amplify(v, Syntax.AsEnumerator<float, T>(value))),
				(e) => e.Wrap((v) => Filter.Amplify(v, Syntax.AsEnumerator<float, T>(value))),
				(e) => e.Wrap((v) => Filter.Amplify(v, Syntax.AsEnumerator<float, T>(value))),
				(e) => e.Wrap((v) => Filter.Amplify(v, Syntax.AsEnumerator<float, T>(value)))
			);
			return self;
		}

		public static MotionBehaviour<V> Offset<V>(this MotionBehaviour<V> self, Func<V> value)
		{
			return Offset<V, Func<V>>(self, value);
		}

		public static MotionBehaviour<V> Amplify<V>(this MotionBehaviour<V> self, Func<V> value)
		{
			return Amplify<V, Func<V>>(self, value);
		}
	}
}