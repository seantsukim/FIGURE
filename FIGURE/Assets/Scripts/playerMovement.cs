using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float moveSpeed = 0f;
	public float jumpHeight = 0f;

	private Rigidbody2D rb;
	private bool isGrounded;

	//Initialize variables
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		isGrounded = true;
	}

	void OnCollisionEnter2D(Collision2D collided)
	{
		//allows for jump once u hit the ground
		if (collided.gameObject.tag == "floor")
		{
			isGrounded = true;
		}
	}
	
	// Update is called once per frame
	void Update () {


	}

	//Player Movement
	void FixedUpdate()
	{	
		//check to move left or right
		float axis = Input.GetAxisRaw("Horizontal");

		//player jump (once)
		if (isGrounded && (Input.GetAxisRaw("Jump") > 0))
		{
			rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
			isGrounded = false;
		}

		//horizontal movement
		rb.velocity = new Vector3(moveSpeed * axis, rb.velocity.y, 0);
	}
}
