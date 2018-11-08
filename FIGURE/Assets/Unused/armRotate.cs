using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armRotate : MonoBehaviour {

	public int rotationOffset = 90; //change the offset if needed
	
	// Update is called once per frame
	void Update () {
		//rotate the arm towards the mouse position when aiming

		Vector3 pointed = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		pointed.Normalize();

		//angle in degrees to rotate in z axis
		float rotationZ = Mathf.Atan2(pointed.y, pointed.x) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + rotationOffset);
	}
}
