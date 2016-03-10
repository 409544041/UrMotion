using UnityEngine;

namespace UrMotion
{
	public class MotionRX : MotionVec1R<MotionRX>
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

	public class MotionRY : MotionVec1R<MotionRY>
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

	public class MotionRZ : MotionVec1R<MotionRZ>
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

	public class MotionRXY : MotionVec2R<MotionRXY>
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

	public class MotionRXZ : MotionVec2R<MotionRXZ>
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

	public class MotionRYZ : MotionVec2R<MotionRYZ>
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

	public class MotionRXYZ : MotionVec3R<MotionRXYZ>
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

	public class MotionWRX : MotionVec1WR<MotionWRX>
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

	public class MotionWRY : MotionVec1WR<MotionWRY>
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

	public class MotionWRZ : MotionVec1WR<MotionWRZ>
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

	public class MotionWRXY : MotionVec2WR<MotionWRXY>
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

	public class MotionWRXZ : MotionVec2WR<MotionWRXZ>
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

	public class MotionWRYZ : MotionVec2WR<MotionWRYZ>
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

	public class MotionWRXYZ : MotionVec3WR<MotionWRXYZ>
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

	public class MotionR : MotionRXY
	{
	}
	public class MotionR3 : MotionRXYZ
	{
	}
	public class MotionWR : MotionWRXY
	{
	}
	public class MotionWR3 : MotionWRXYZ
	{
	}
}