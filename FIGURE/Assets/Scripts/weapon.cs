﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

	public Transform fireOrigin; //where to instantiate bullet
	//public float fireCooldown = 0.5f;
	public float bulletSpeed = 0.5f; //how fast the bullet should travel
	public float rateOfFire = 0.25f; //how long to wait before firing
	public float bulletDuration = 2.0f; //how long the bullet should last
	public Object bullet; //the bullet object being fired

	private float bulletCooldown; //bullet buffer

	void Start() {
		bulletCooldown = 0f;
	}

	void fire()
	{
		//Debug.Log("Pew!");
		/*
		Vector2 mousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		Vector2 fireCoordinates = new Vector2(fireOrigin.transform.position.x, fireOrigin.transform.position.y);
		RaycastHit2D hit = Physics2D.Raycast(fireCoordinates, mousePos - fireCoordinates, 1000);
		*/
		var newBullet = (GameObject)Instantiate(bullet, fireOrigin.position, fireOrigin.rotation);
		newBullet.GetComponent<Rigidbody2D>().velocity = newBullet.transform.right * bulletSpeed;

		Destroy(newBullet, bulletDuration);
	}
	
	// Update is called once per frame
	void Update () {
		bulletCooldown += Time.deltaTime * 1;

		if (Input.GetButton("Fire1") && (bulletCooldown >= rateOfFire))
		{
			fire();
			bulletCooldown = 0;
		}
	}
}
