using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    // Get game object 
    public GameObject enemySpawner;

    // Setting public float for movement speed and getting rigidbody2D
    public float moveSpeed;
    private Rigidbody2D enemySpawnerRigidbody2D;

    // Vectors for user input and setting velocity
    private Vector2 moveInput;
    private Vector2 moveVelocity;

    // Setting spawner movement speed and initialising spawner timer
    public float spawnerMovementSpeed = 5;
    private float moveTimer = 0.0f;
    private float spawnerTimer = 0.0f;

    // Getting rigidbody2D component
    private void Start() {
        enemySpawnerRigidbody2D = GetComponent<Rigidbody2D>();

        // Not needed? Test
        Instantiate(enemySpawner, transform.position, Quaternion.identity);
    }

    // Move enemy spawner up and down the Y axis on timer
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

    // Set the velocity of the spawner and instantiate enemies on timer
    private void FixedUpdate() {

        enemySpawnerRigidbody2D.velocity = moveVelocity;

        spawnerTimer += Time.deltaTime;

        if (spawnerTimer > 1.5) {
            Instantiate(enemySpawner, transform.position, Quaternion.identity);
            spawnerTimer = 0;
        }       
    }
}
