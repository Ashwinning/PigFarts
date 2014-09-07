using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		MoveUp();
	}

	void MoveUp ()
	{
		transform.Translate(Vector3.up * (Player.MoveSpeed - 0.02f));
	}

}
