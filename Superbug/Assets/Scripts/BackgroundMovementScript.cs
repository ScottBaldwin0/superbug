using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovementScript : MonoBehaviour
{
	// Get game objects
	public GameObject backgroundLayer;

	// Movement speed and rigidbody2D
	public float moveSpeed;
	private Rigidbody2D backgroundRigidbody2D;

	// Vectors for user input and setting velocity
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	// Get rigidbody2D at start
	private void Start() {
		backgroundRigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Calculate background movement speed and direction
	private void Update() {
		moveInput = new Vector3(2f, 0f);
		moveVelocity = moveInput * moveSpeed;

		// Destory backgrounds when they are out of camera view
		if (transform.position.x <= -25) {
			GameObject.Destroy(backgroundLayer);
		}
	}

	// Apply movement to the bullet
	private void FixedUpdate() {
		backgroundRigidbody2D.velocity = moveVelocity;
	}
}
