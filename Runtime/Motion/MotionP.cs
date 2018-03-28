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

	public class MotionXYZ : MotionVec3P<MotionXYZ>
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

	public class MotionWX : MotionVec1WP<MotionWX>
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

	public class MotionWY : MotionVec1WP<MotionWY>
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

	public class MotionWZ : MotionVec1WP<MotionWZ>
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

	public class MotionWXY : MotionVec2WP<MotionWXY>
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

	public class MotionWXZ : MotionVec2WP<MotionWXZ>
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

	public class MotionWYZ : MotionVec2WP<MotionWYZ>
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

	public class MotionWXYZ : MotionVec3WP<MotionWXYZ>
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

	public class MotionP : MotionXY
	{
	}
	public class MotionP3 : MotionXYZ
	{
	}
	public class MotionWP : MotionWXY
	{
	}
	public class MotionWP3 : MotionWXYZ
	{
	}
}