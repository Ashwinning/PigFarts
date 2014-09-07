using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	private Vector2 leftFingerPos = Vector2.zero;
	private Vector2 leftFingerLastPos = Vector2.zero;
	private Vector2 leftFingerMovedBy = Vector2.zero;
	
	public static float slideMagnitudeX  = 0.0f;
	public static float slideMagnitudeY  = 0.0f;

	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1)
		{
			Touch touch;
			touch = Input.GetTouch(0);
			
			if (touch.phase == TouchPhase.Began)
			{
				leftFingerPos = Vector2.zero;
				leftFingerLastPos = Vector2.zero;
				leftFingerMovedBy = Vector2.zero;
				
				slideMagnitudeX = 0;
				slideMagnitudeY = 0;
				
				// record start position
				leftFingerPos = touch.position;
				
			}
			
			else if (touch.phase == TouchPhase.Moved)
			{
				leftFingerMovedBy = touch.position - leftFingerPos; // or Touch.deltaPosition : Vector2
				// The position delta since last change.
				leftFingerLastPos = leftFingerPos;
				leftFingerPos = touch.position;
				
				// slide horz
				slideMagnitudeX = leftFingerMovedBy.x / Screen.width;
				
				// slide vert
				slideMagnitudeY = leftFingerMovedBy.y / Screen.height;
				
			}
			
			else if (touch.phase == TouchPhase.Stationary)
			{
				leftFingerLastPos = leftFingerPos;
				leftFingerPos = touch.position;
				
				slideMagnitudeX = 0.0f;
				slideMagnitudeY = 0.0f;
			}
			
			else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
			{
				slideMagnitudeX = 0.0f;
				slideMagnitudeY = 0.0f;
			}
		}
	}
}

