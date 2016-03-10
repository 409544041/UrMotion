using UnityEngine;

namespace UrMotion
{
	public class MotionSX : MotionVec1S<MotionSX>
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

	public class MotionSY : MotionVec1S<MotionSY>
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

	public class MotionSZ : MotionVec1S<MotionSZ>
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

	public class MotionSXY : MotionVec2S<MotionSXY>
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

	public class MotionSXZ : MotionVec2S<MotionSXZ>
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

	public class MotionSYZ : MotionVec2S<MotionSYZ>
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

	public class MotionSXYZ : MotionVec3S<MotionSXYZ>
	{
		override protected Vector3 value {
			get {
				return vector;
			}
			set {
				vector = value;
			}
		}
	}

	public class MotionS : MotionSXY
	{
	}
	public class MotionS3 : MotionSXYZ
	{
	}
}