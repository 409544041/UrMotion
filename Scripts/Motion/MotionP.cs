using UnityEngine;

namespace UrMotion
{
	public class MotionX : MotionVec1P
	{
		public static MotionBehaviour<float> Add(GameObject g)
		{
			return Add<MotionX>(g);
		}

		override protected float value {
			get {
				return vector.x;
			}
			set {
				Vector3 v = vector;
				v.x = value;
				vector = v;
			}
		}
	}
}