using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionScript : MonoBehaviour
{
	// Get game objects
	public GameObject enemy;
	public GameObject bullet;

	// Check for collisions with bullets and destroy self (not working yet)
	private void OnCollisionEnter(Collision collision) {
		if (bullet) {
			GameObject.Destroy(enemy);
		}
	}
}
