using UnityEngine;

namespace UrMotion
{
	using MotionBehaviourVec1 = MotionBehaviour<float>;

	public static class MotionPSyntax
	{
		public static MotionBehaviourVec1 MotionX(this GameObject g)
		{
			return UrMotion.MotionX.Add(g);
		}
	}
}