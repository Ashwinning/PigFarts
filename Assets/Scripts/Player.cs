using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static float MoveSpeed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate() {
		rigidbody.AddForce(0, TouchController.slideMagnitudeX, 0);
	}
	
	
}
