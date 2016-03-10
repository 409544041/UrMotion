using UnityEngine;

namespace UrMotion
{
	public class MotionX : MotionVec1P<MotionX>
	{
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

	public class MotionY : MotionVec1P<MotionY>
	{
		override protected float value {
			get {
				return vector.y;
			}
			set {
				Vector3 v = vector;
				v.y = value;
				vector = v;
			}
		}
	}

	public class MotionZ : MotionVec1P<MotionZ>
	{
		override protected float value {
			get {
				return vector.z;
			}
			set {
				Vector3 v = vector;
				v.z = value;
				vector = v;
			}
		}
	}

	public class MotionXY : MotionVec2P<MotionXY>
	{
		override protected Vector2 value {
			get {
				return new Vector2(vector.x, vector.y);
			}
			set {
				Vector3 v = vector;
				v.x = value.x;
				v.y = value.y;
				vector = v;
			}
		}
	}

	public class MotionXZ : MotionVec2P<MotionXZ>
	{
		override protected Vector2 value {
			get {
				return new Vector2(vector.x, vector.z);
			}
			set {
				Vector3 v = vector;
				v.x = value.x;
				v.z = value.y;
				vector = v;
			}
		}
	}

	public class MotionYZ : MotionVec2P<MotionYZ>
	{
		override protected Vector2 value {
			get {
				return new Vector2(vector.y, vector.z);
			}
			set {
				Vector3 v = vector;
				v.y = value.x;
				v.z = value.y;
				vector = v;
			}
		}
	}
}