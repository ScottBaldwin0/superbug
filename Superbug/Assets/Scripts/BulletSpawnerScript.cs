using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerScript : MonoBehaviour {
	public GameObject bulletSpawner;

	public float moveSpeed;
	private Rigidbody2D bulletSpawnerRigidbody2D;

	private Vector2 moveInput;
	private Vector2 moveVelocity;

	public float spawnerMovementSpeed = 5;

	private float spawnerTimer = 0.0f;

	private void Start() {
		bulletSpawnerRigidbody2D = GetComponent<Rigidbody2D>();

		Instantiate(bulletSpawner, transform.position, Quaternion.identity);
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
