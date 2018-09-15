using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

	public Transform fireOrigin;
	public float fireRate = 0.5f;
	public float bulletSpeed = 0.5f;
	public float bulletDuration = 2.0f;
	public Object bullet;

	void Awake () {
		
	}

	void fire()
	{
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			fire();
		}
	}
}
