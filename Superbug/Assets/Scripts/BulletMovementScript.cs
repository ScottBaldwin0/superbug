using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovementScript : MonoBehaviour
{
	// Get game objects
	public GameObject bullet;

	// Movement speed and rigidbody2D
	public float moveSpeed;
	private Rigidbody2D bulletRigidbody2D;

	// Vectors for user input and setting velocity
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	// Get rigidbody2D at start
	private void Start() {
		bulletRigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Calculate bullet movement speed and direction
	private void Update() {
		moveInput = new Vector3(2f, 0f);
		moveVelocity = moveInput * moveSpeed;

		// Destory bullets when they are out of camera view
		if (transform.position.x >= 15) {
			GameObject.Destroy(bullet);
		}
	}

	// Apply movement to the bullet
	private void FixedUpdate() {
		bulletRigidbody2D.velocity = moveVelocity;
	}
}
