using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerScript : MonoBehaviour {

	// Get game object 
	public GameObject bulletSpawner;

	// Setting public float for movement speed and getting rigidbody2D
	public float moveSpeed;
	private Rigidbody2D bulletSpawnerRigidbody2D;

	// Vectors for user input and setting velocity
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	// Setting spawner movement speed and initialising spawner timer
	public float spawnerMovementSpeed = 5;
	private float spawnerTimer = 0.0f;

	// Getting rigidbody2D component
	private void Start() {
		bulletSpawnerRigidbody2D = GetComponent<Rigidbody2D>();
	}

	private void Update() {


		moveInput = new Vector2(0f, -0.5f);
		moveVelocity = moveInput * moveSpeed;

		moveInput = new Vector2(0f, 0.5f);
		moveVelocity = moveInput * moveSpeed;

	}

		private void FixedUpdate() {

			bulletSpawnerRigidbody2D.velocity = moveVelocity;

			spawnerTimer += Time.deltaTime;

			if (Input.GetKeyDown("space")) {
				Instantiate(bulletSpawner, transform.position, Quaternion.identity);
				spawnerTimer = 0;
			}

		}
	}
