using UnityEngine;

namespace UrMotion
{
	using MotionBehaviourVec1 = MotionBehaviour<float>;
	using MotionBehaviourVec2 = MotionBehaviour<Vector2>;

	public static class MotionPSyntax
	{
		public static MotionBehaviourVec1 MotionX(this GameObject g)
		{
			return UrMotion.MotionX.Add(g);
		}

		public static MotionBehaviourVec1 MotionY(this GameObject g)
		{
			return UrMotion.MotionY.Add(g);
		}

		public static MotionBehaviourVec1 MotionZ(this GameObject g)
		{
			return UrMotion.MotionZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionXY(this GameObject g)
		{
			return UrMotion.MotionXY.Add(g);
		}

		public static MotionBehaviourVec2 MotionXZ(this GameObject g)
		{
			return UrMotion.MotionXZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionYZ(this GameObject g)
		{
			return UrMotion.MotionYZ.Add(g);
		}
	}
}