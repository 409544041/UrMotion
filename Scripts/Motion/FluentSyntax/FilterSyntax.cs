using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	using Syntax = UrMotion.FluentSyntax;

	public static class FilterSyntax
	{
		public static MotionBehaviour<V> Map<V, T>(this MotionBehaviour<V> self, Func<V, V> map)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Wrap((v) => Filter.Map<float  >(v, (Func<float,   float  >)(object)map)),
				(e) => e.Wrap((v) => Filter.Map<Vector2>(v, (Func<Vector2, Vector2>)(object)map)),
				(e) => e.Wrap((v) => Filter.Map<Vector3>(v, (Func<Vector3, Vector3>)(object)map)),
				(e) => e.Wrap((v) => Filter.Map<Vector4>(v, (Func<Vector4, Vector4>)(object)map))
			);
			return self;
		}

		public static MotionBehaviour<V> Negate<V>(this MotionBehaviour<V> self)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Wrap((v) => Filter.Negate(v)),
				(e) => e.Wrap((v) => Filter.Negate(v)),
				(e) => e.Wrap((v) => Filter.Negate(v)),
				(e) => e.Wrap((v) => Filter.Negate(v))
			);
			return self;
		}

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

		public static MotionBehaviour<V> Discrete<V, T>(this MotionBehaviour<V> self, T interval)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Wrap((v) => Filter.Discrete(v, Syntax.AsEnumerator<float, T>(interval))),
				(e) => e.Wrap((v) => Filter.Discrete(v, Syntax.AsEnumerator<float, T>(interval))),
				(e) => e.Wrap((v) => Filter.Discrete(v, Syntax.AsEnumerator<float, T>(interval))),
				(e) => e.Wrap((v) => Filter.Discrete(v, Syntax.AsEnumerator<float, T>(interval)))
			);
			return self;
		}

		public static MotionBehaviour<V> Offset<V>(this MotionBehaviour<V> self, Func<V> value)
		{
			return Offset<V, Func<V>>(self, value);
		}

		public static MotionBehaviour<V> Amplify<V>(this MotionBehaviour<V> self, Func<float> value)
		{
			return Amplify<V, Func<float>>(self, value);
		}

		public static MotionBehaviour<V> Discrete<V>(this MotionBehaviour<V> self, Func<float> interval)
		{
			return Discrete<V, Func<float>>(self, interval);
		}

		public static IEnumerator<V> Map<V>(this IEnumerator<V> source, Func<V, V> value)
		{
			return Filter.Map<V>(source, value);
		}

		public static IEnumerator<V> Offset<V, T>(this IEnumerator<V> source, T value)
		{
			var res = default(IEnumerator<V>);
			Syntax.Resolve<V>(
				() => res = Filter.Offset(source as IEnumerator<float  >, Syntax.AsEnumerator<float,   T>(value)) as IEnumerator<V>,
				() => res = Filter.Offset(source as IEnumerator<Vector2>, Syntax.AsEnumerator<Vector2, T>(value)) as IEnumerator<V>,
				() => res = Filter.Offset(source as IEnumerator<Vector3>, Syntax.AsEnumerator<Vector3, T>(value)) as IEnumerator<V>,
				() => res = Filter.Offset(source as IEnumerator<Vector4>, Syntax.AsEnumerator<Vector4, T>(value)) as IEnumerator<V>
			);
			return res;
		}

		public static IEnumerator<V> Negate<V>(this IEnumerator<V> source)
		{
			var res = default(IEnumerator<V>);
			Syntax.Resolve<V>(
				() => res = Filter.Negate(source as IEnumerator<float  >) as IEnumerator<V>,
				() => res = Filter.Negate(source as IEnumerator<Vector2>) as IEnumerator<V>,
				() => res = Filter.Negate(source as IEnumerator<Vector3>) as IEnumerator<V>,
				() => res = Filter.Negate(source as IEnumerator<Vector4>) as IEnumerator<V>
			);
			return res;
		}

		public static IEnumerator<V> Amplify<V, T>(this IEnumerator<V> source, T value)
		{
			var res = default(IEnumerator<V>);
			Syntax.Resolve<V>(
				() => res = Filter.Amplify(source as IEnumerator<float  >, Syntax.AsEnumerator<float, T>(value)) as IEnumerator<V>,
				() => res = Filter.Amplify(source as IEnumerator<Vector2>, Syntax.AsEnumerator<float, T>(value)) as IEnumerator<V>,
				() => res = Filter.Amplify(source as IEnumerator<Vector3>, Syntax.AsEnumerator<float, T>(value)) as IEnumerator<V>,
				() => res = Filter.Amplify(source as IEnumerator<Vector4>, Syntax.AsEnumerator<float, T>(value)) as IEnumerator<V>
			);
			return res;
		}

		public static IEnumerator<V> Discrete<V, T>(this IEnumerator<V> source, T interval)
		{
			var res = default(IEnumerator<V>);
			Syntax.Resolve<V>(
				() => res = Filter.Discrete(source as IEnumerator<float  >, Syntax.AsEnumerator<float, T>(interval)) as IEnumerator<V>,
				() => res = Filter.Discrete(source as IEnumerator<Vector2>, Syntax.AsEnumerator<float, T>(interval)) as IEnumerator<V>,
				() => res = Filter.Discrete(source as IEnumerator<Vector3>, Syntax.AsEnumerator<float, T>(interval)) as IEnumerator<V>,
				() => res = Filter.Discrete(source as IEnumerator<Vector4>, Syntax.AsEnumerator<float, T>(interval)) as IEnumerator<V>
			);
			return res;
		}

		public static IEnumerator<float> ToAngle(this IEnumerator<Vector2> source)
		{
			return Filter.ToAngle(source);
		}

		public static IEnumerator<Vector3> ToAngle(this IEnumerator<Vector3> source)
		{
			return Filter.ToAngle(source);
		}

		public static IEnumerator<V> Offset<V>(this IEnumerator<V> source, Func<V> value)
		{
			return Offset<V, Func<V>>(source, value);
		}

		public static IEnumerator<V> Amplify<V>(this IEnumerator<V> source, Func<float> value)
		{
			return Amplify<V, Func<float>>(source, value);
		}

		public static IEnumerator<V> Discrete<V>(this IEnumerator<V> source, Func<float> interval)
		{
			return Discrete<V, Func<float>>(source, interval);
		}
	}
}