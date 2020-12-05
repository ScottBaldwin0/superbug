using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemySpawner;

    public float moveSpeed;
    private Rigidbody2D enemySpawnerRigidbody2D;

    private Vector2 moveInput;
    private Vector2 moveVelocity;

    public float spawnerMovementSpeed = 5;
    private float moveTimer = 0.0f;
    private float spawnerTimer = 0.0f;

    private void Start() {
        enemySpawnerRigidbody2D = GetComponent<Rigidbody2D>();

        Instantiate(enemySpawner, transform.position, Quaternion.identity);
    }

    private void Update() {

        moveTimer += Time.deltaTime;

        if (moveTimer < 2.5) {
            moveInput = new Vector2(0f, -0.5f);
            moveVelocity = moveInput * moveSpeed;
        } else if (moveTimer < 5) {
            moveInput = new Vector2(0f, 0.5f);
            moveVelocity = moveInput * moveSpeed;
        } else {
            moveTimer = 0;
        }
    }

    private void FixedUpdate() {

        enemySpawnerRigidbody2D.velocity = moveVelocity;

        spawnerTimer += Time.deltaTime;

        if (spawnerTimer > 1.5) {
            Instantiate(enemySpawner, transform.position, Quaternion.identity);
            spawnerTimer = 0;
        }
        
    }

}
