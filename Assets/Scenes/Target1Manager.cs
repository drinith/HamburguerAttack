using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target1Manager : MonoBehaviour {

//	public PlayerHealth playerHealth;
	public Rigidbody target;
	public Rigidbody targetClone;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;
	Vector3 whereToSpawn ;


	void Start(){

		//Delay da chamada do Spawn
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Update(){


	}

	void Spawn ()
	{
		// If the player has no health left...
//		if(playerHealth.currentHealth <= 0f)
//		{
//			// ... exit the function.
//			return;
//		}

		// Find a random index between zero and one less than the number of spawn points.
		float randX = Random.Range (-19.5f, 19.5f);

		whereToSpawn = new Vector3 (randX, 0f, 19.5f);
		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		targetClone=(Rigidbody) Instantiate (target, whereToSpawn, Quaternion.identity);


		if (Mathf.Abs(targetClone.position.x) >= 100 || Mathf.Abs(targetClone.position.z) >= 100)
		{
			Destroy(targetClone);
		}
	}
}
