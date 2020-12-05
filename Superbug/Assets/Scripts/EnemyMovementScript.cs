using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D enemyRigidbody2D;

	private Vector2 moveInput;
	private Vector2 moveVelocity;

	private void Start() {
		enemyRigidbody2D = GetComponent<Rigidbody2D>();
	}

	private void Update() {
		moveInput = new Vector3(2f, 0f);
		moveVelocity = moveInput * moveSpeed;
	}

	private void FixedUpdate() {
		enemyRigidbody2D.velocity = moveVelocity;
	}
}
