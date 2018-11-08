using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour {

	public enemyInfo enemy; //put in the scriptable object of enemy here

	void OnTriggerEnter2D(Collider2D collided)
	{
		if (collided.tag == "bullet")
		{
			enemy.health--;
		}
	}

	// Update is called once per frame
	void Update () {
		Debug.Log("Health of " + enemy.name + " is: " + enemy.health);
	}
}
