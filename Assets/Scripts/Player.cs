using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static float MoveSpeed = 0.1f;

	private bool canMove = true;

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter ()
	{
			Debug.Log("Collision");
			canMove = false;
	}

	void OnCollisionExit ()
	{
		canMove = true;
	}

	void Update ()
	{
		if (canMove)
		{
			transform.Translate(Vector3.up * MoveSpeed);
		}
	}


	IEnumerator MoveRight()
	{
		//If object is to the left of center, move to center
		if(transform.position.x < 0.0f) 
		{
			iTween.MoveTo(gameObject,iTween.Hash(
				"x"   , 0,
				"time", 0.2f
				));
		}
		//If obj is at center, move right
		if (transform.position.x == 0.0f)
		{
			iTween.MoveTo(gameObject,iTween.Hash(
				"x"   , 4,
				"time", 0.2f
				));
		}
		return null;
	}


	IEnumerator MoveLeft()
	{
		//if obj is to the right of center, move to center
		if (transform.position.x > 0.0f)
		{
			iTween.MoveTo(gameObject,iTween.Hash(
				"x"   , 0,
				"time", 0.2f
				));
		}
		//if obj is at center, move left
		if (transform.position.x == 0.0f)
		{
			iTween.MoveTo(gameObject,iTween.Hash(
				"x"   , -4,
				"time", 0.2f
				));
		}
		return null;
	}
	
}
