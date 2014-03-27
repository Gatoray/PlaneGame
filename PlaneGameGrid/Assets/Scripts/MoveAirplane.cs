using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveAirplane : MonoBehaviour {

	public float interval;
	private bool keyCheck = false; //checks whether the button was held down last frame

	// Update is called once per frame
	void Update ()
	{
		// Boundary to ensure that the plane does not go outside its fixed boundary
		// EDITED BY EDWARD KIM (03/24/14)
		Vector3 bound = transform.position;
		bound.x = Mathf.Clamp(bound.x, -36.0f, 36.0f);
		bound.y = Mathf.Clamp(bound.y, -36.0f, 36.0f);
		bound.z = Mathf.Clamp(bound.z, 0.0f, 0.0f);
		transform.position = bound;

		float moveVertical = Input.GetAxisRaw ("Vertical") * interval;
		float moveHorizontal = Input.GetAxisRaw ("Horizontal") * interval;
		
		if (Input.anyKeyDown == true && keyCheck == false)
		{
			keyCheck = true;
			transform.Translate (moveHorizontal, moveVertical, 0);
		} 
		else
		{
			keyCheck = false;
		}
	}
}



// The type or namespace could not be found. Are you missing a using directive or an assembly reference?