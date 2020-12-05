using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
	// Get gaem object
	public GameObject enemy;

	// Set enemy movement speed and getting the rigidbody2D
    public float moveSpeed;
    private Rigidbody2D enemyRigidbody2D;

	// Getting input and velocity
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	// Getting the rigidbody2D component
	private void Start() {
		enemyRigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Sets enemy movement velocity and direction 
	private void Update() {
		moveInput = new Vector3(2f, 0f);
		moveVelocity = moveInput * moveSpeed;

		// Destroys enemies that leave the bounds of the camera view
		if (transform.position.x <= -12) {
			GameObject.Destroy(enemy);
		}
	}

	// Applies velcoity to the enemy rigidbody2D 
	private void FixedUpdate() {
		enemyRigidbody2D.velocity = moveVelocity;
	}
}
