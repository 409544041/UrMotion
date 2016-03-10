using UnityEngine;
using UnityEngine.UI;

namespace UrMotion
{
	public class MotionFillAmount : MotionVec1<MotionFillAmount>
	{
		Image im;

		protected Image GetImage()
		{
			return im ?? (im = GetComponent<Image>());
		}

		override protected float value {
			get {
				return GetImage().fillAmount;
			}
			set {
				GetImage().fillAmount = value;
			}
		}
	}
}