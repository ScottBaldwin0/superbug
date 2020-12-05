using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawnerScript : MonoBehaviour
{
    public GameObject backgroundLayer;

    private float spawnerTimer = 0.0f;
    public float timer = 0.0f;

	// Instantiates one background layer on start
	private void Start() {
        Instantiate(backgroundLayer, transform.position, Quaternion.identity);
    }

	// Checks spawner timer against public timer in editor
	private void FixedUpdate() {

        spawnerTimer += Time.deltaTime;

        if (spawnerTimer > timer) {
            Instantiate(backgroundLayer, transform.position, Quaternion.identity);
            spawnerTimer = 0;
        }      
    }
}
