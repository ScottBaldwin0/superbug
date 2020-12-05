using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
	// Getting player movement speed and rigidbody2D
    public float moveSpeed;
    private Rigidbody2D playerRigidbody2D;

	// Gets player input and velocity
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	// Getting the rigidbody2D component
	private void Start() {
		playerRigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Gets player inputs and calculates velocity
	private void Update() {
		moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput * moveSpeed;
	}

	// Applies velocity to the players rigidbody2D
	private void FixedUpdate() {
		playerRigidbody2D.velocity = moveVelocity;
	}
}
