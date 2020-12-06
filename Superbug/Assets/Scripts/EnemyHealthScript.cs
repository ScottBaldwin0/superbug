using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject enemy;

    public float enemyHealth = 0.0f;
    public float bulletDamage = 0.0f;

    private bool enemyIsDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Triggered");
	}
}
