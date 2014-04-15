using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {
	public float currentHealth = 100;
	public float maxHealth = 100;
	public int health;
	
	public void OnMouseDown()
	{
		if (Input.GetMouseButtonDown(0))
		{
			currentHealth -= 1;
			if (currentHealth == 0)
				Destroy(gameObject);
		}

	}
	
	// Update is called once per frame
//	void Update () {
//		if ( Physics.Raycast (transform.position, 
//		// If mouse clicked on it, subtract current health by 1
//		if (Input.GetMouseButtonDown(0) && )
//		{
//			currentHealth -= 1;
//			if ( currentHealth == 0 )
//				Destroy(gameObject);
//		}
//	}
//
	void OnGUI () {
		
		GUI.Box (new Rect(0, 0, 200, 20), currentHealth + "/" + maxHealth);
		
	}

}