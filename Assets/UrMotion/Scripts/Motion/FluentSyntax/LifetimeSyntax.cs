namespace UrMotion
{
	public static class LifetimeSyntax
	{
		public static MotionBehaviour<V> Lifetime<V>(this MotionBehaviour<V> self, float frames)
		{
			return self;
		}
	}
}