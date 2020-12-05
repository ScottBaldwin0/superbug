using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovementScript : MonoBehaviour
{
	public GameObject bullet;

	public float moveSpeed;
	private Rigidbody2D bulletRigidbody2D;

	private Vector2 moveInput;
	private Vector2 moveVelocity;

	private void Start() {
		bulletRigidbody2D = GetComponent<Rigidbody2D>();
	}

	private void Update() {
		moveInput = new Vector3(2f, 0f);
		moveVelocity = moveInput * moveSpeed;

		if (transform.position.x >= 15) {
			GameObject.Destroy(bullet);
		}
	}

	private void FixedUpdate() {
		bulletRigidbody2D.velocity = moveVelocity;
	}
}
