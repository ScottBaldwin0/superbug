using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D playerRigidbody2D;

	private Vector2 moveInput;
	private Vector2 moveVelocity;

	private void Start() {
		playerRigidbody2D = GetComponent<Rigidbody2D>();
	}

	private void Update() {
		moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput * moveSpeed;
	}

	private void FixedUpdate() {
		playerRigidbody2D.velocity = moveVelocity;
	}
}
