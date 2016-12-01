using UnityEngine;

namespace Lean.Touch
{
	// This script allows you to transform the GameObject selected by LeanSelect3D
	public class LeanSelect3DTransform : LeanSelect3D
	{
		public bool AllowTranslate = true;

		public bool AllowRotate = true;

		public bool AllowScale = true;

		protected virtual void Update()
		{
			// Make sure we have something selected
			if (SelectedGameObject != null)
			{
				// Make sure the main camera exists
				if (Camera.main != null)
				{
					if (AllowTranslate == true)
					{
						Translate(SelectedGameObject.transform, LeanTouch.DragDelta);
					}

					if (AllowRotate == true)
					{
						Rotate(SelectedGameObject.transform, LeanTouch.TwistDegrees);
					}

					if (AllowScale == true)
					{
						Scale(SelectedGameObject.transform, LeanTouch.PinchScale);
					}
				}
			}
		}

		public void Translate(Transform transform_select, Vector2 screenPositionDelta)
		{
            float Y = transform_select.position.y;
			// Screen position of the transform
            var screenPosition = Camera.main.WorldToScreenPoint(transform_select.position);
			
			// Add the deltaPosition
			screenPosition += (Vector3)screenPositionDelta;
			
			// Convert back to world space
            transform_select.position = Camera.main.ScreenToWorldPoint(screenPosition);
            transform_select.position = new Vector3(transform_select.position.x,Y,transform_select.position.z);
		}

		public void Rotate(Transform transform, float angleDelta)
		{
            transform.rotation *= Quaternion.Euler(0.0f, angleDelta, 0.0f);
		}

		public void Scale(Transform transform, float scale)
		{
			// Make sure the scale is valid
			if (scale > 0.0f)
			{
				// Grow the local scale by scale
				transform.localScale *= scale;
			}
		}
	}
}