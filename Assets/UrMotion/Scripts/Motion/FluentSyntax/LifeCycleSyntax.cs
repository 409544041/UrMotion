using System;

namespace UrMotion
{
	using Syntax = UrMotion.FluentSyntax;

	public static class LifeCycleSyntax
	{
		public static MotionBehaviour<V> Lifetime<V, T>(this MotionBehaviour<V> self, T period)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Wrap((v) => LifeCycle.Lifetime(v, Syntax.AsEnumerator<float, T>(period))),
				(e) => e.Wrap((v) => LifeCycle.Lifetime(v, Syntax.AsEnumerator<float, T>(period))),
				(e) => e.Wrap((v) => LifeCycle.Lifetime(v, Syntax.AsEnumerator<float, T>(period))),
				(e) => e.Wrap((v) => LifeCycle.Lifetime(v, Syntax.AsEnumerator<float, T>(period)))
			);
			return self;
		}

		public static MotionBehaviour<V> Delay<V, T>(this MotionBehaviour<V> self, T delay)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Wrap((v) => LifeCycle.Delay(v, Syntax.AsEnumerator<float, T>(delay))),
				(e) => e.Wrap((v) => LifeCycle.Delay(v, Syntax.AsEnumerator<float, T>(delay))),
				(e) => e.Wrap((v) => LifeCycle.Delay(v, Syntax.AsEnumerator<float, T>(delay))),
				(e) => e.Wrap((v) => LifeCycle.Delay(v, Syntax.AsEnumerator<float, T>(delay)))
			);
			return self;
		}

		public static MotionBehaviour<V> Threshold<V, T>(this MotionBehaviour<V> self, T threshold)
		{
			Syntax.Resolve<V>(self,
				(e) => e.Wrap((v) => LifeCycle.Threshold(v, Syntax.AsEnumerator<float, T>(threshold))),
				(e) => e.Wrap((v) => LifeCycle.Threshold(v, Syntax.AsEnumerator<float, T>(threshold))),
				(e) => e.Wrap((v) => LifeCycle.Threshold(v, Syntax.AsEnumerator<float, T>(threshold))),
				(e) => e.Wrap((v) => LifeCycle.Threshold(v, Syntax.AsEnumerator<float, T>(threshold)))
			);
			return self;
		}

		public static MotionBehaviour<V> Lifetime<V>(this MotionBehaviour<V> self, Func<float> period)
		{
			return Lifetime<V, Func<float>>(self, period);
		}

		public static MotionBehaviour<V> Delay<V>(this MotionBehaviour<V> self, Func<float> delay)
		{
			return Delay<V, Func<float>>(self, delay);
		}

		public static MotionBehaviour<V> Threshold<V>(this MotionBehaviour<V> self)
		{
			return Threshold<V, float>(self, 0.01f);
		}

		public static MotionBehaviour<V> Threshold<V>(this MotionBehaviour<V> self, Func<V> threshold)
		{
			return Threshold<V, Func<V>>(self, threshold);
		}
	}
}