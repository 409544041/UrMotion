using UnityEngine;

namespace UrMotion
{
	public abstract class MotionVec1 : MotionBehaviour<float>
	{
		public static MotionBehaviour<float> Add<T>(GameObject g) where T : MotionVec1
		{
			return Get<T, float>(g);
		}

		override protected float Add(float a, float b)
		{
			return a + b;
		}
	}

	public abstract class MotionVec1T : MotionVec1
	{
		public abstract Vector3 vector { get; set; }

		Transform t;

		protected Transform GetTransform()
		{
			return t ?? (t = transform);
		}
	}

	public abstract class MotionVec1P : MotionVec1T
	{
		override public Vector3 vector {
			get {
				return GetTransform().localPosition;
			}
			set {
				GetTransform().localPosition = value;
			}
		}
	}

	public abstract class MotionVec1WP : MotionVec1T
	{
		override public Vector3 vector {
			get {
				return GetTransform().position;
			}
			set {
				GetTransform().position = value;
			}
		}
	}

	public abstract class MotionVec1R : MotionVec1T
	{
		override public Vector3 vector {
			get {
				return GetTransform().localEulerAngles;
			}
			set {
				GetTransform().localEulerAngles = value;
			}
		}
	}

	public abstract class MotionVec1WR : MotionVec1T
	{
		override public Vector3 vector {
			get {
				return GetTransform().eulerAngles;
			}
			set {
				GetTransform().eulerAngles = value;
			}
		}
	}

	public abstract class MotionVec1S : MotionVec1T
	{
		override public Vector3 vector {
			get {
				return GetTransform().localScale;
			}
			set {
				GetTransform().localScale = value;
			}
		}
	}
}