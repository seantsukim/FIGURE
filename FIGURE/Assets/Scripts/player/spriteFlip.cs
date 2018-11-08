using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteFlip : MonoBehaviour {

	public GameObject playerObj; //gameObject that is holding the player
	public GameObject armObj; //gameObject that is holding the arm

	// Use this for initialization
	void Start () {
	}

	void flip()
	{
		//holds position of the mouse, we will be checking the x position
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

		//if mouse is on the left side, flip player left and arm flip back up
		if (mousePos.x < 0)
		{
			playerObj.transform.localScale = new Vector3(-1, 
				playerObj.transform.localScale.y, playerObj.transform.localScale.z);
			armObj.transform.localScale = new Vector3(armObj.transform.localScale.x, -1, 
				armObj.transform.localScale.z);
		}

		//else, flip player to right and arm flip back up
		else
		{
			playerObj.transform.localScale = new Vector3(1, 
				playerObj.transform.localScale.y, playerObj.transform.localScale.z);
			armObj.transform.localScale = new Vector3(armObj.transform.localScale.x, 1, 
				armObj.transform.localScale.z);
		}
	}
	
	// Update is called once per frame
	void Update () {
		flip();
	}
}
