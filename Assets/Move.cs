using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	private float movementSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {
		MoveControl();
	}

	// Moves the object based on keyboard input.
	void MoveControl() {
		var x = Input.GetAxis("Horizontal") * movementSpeed;
		var z = Input.GetAxis("Vertical") * movementSpeed;

		transform.Translate(x, 0, z);
	}
}
