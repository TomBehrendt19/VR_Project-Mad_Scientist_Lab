using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public int healthDamage = 100;               // The amount of health taken away per attack.
	GameObject player;                          // Reference to the player GameObject.
	public float projectilesLifeSpan = 3f; //Fire delay between shots
	//Timer
	private float timer;
	Collider thisGameObjectsCollider;
	CapsuleCollider playerGameObjectsCollider;
	Rigidbody rb;
	public GameObject bang;

	void Awake ()
	{
		// Setting up the references.
		player = GameObject.FindGameObjectWithTag ("Player");
		playerGameObjectsCollider = player.GetComponent<CapsuleCollider> ();
		thisGameObjectsCollider = GetComponent<Collider> ();
		Physics.IgnoreCollision (playerGameObjectsCollider, thisGameObjectsCollider);
		Rigidbody rb = GetComponent<Rigidbody> ();



	}
	void Update(){

		timer += Time.deltaTime;

		//If enought time has passed shoot
		if(timer >= projectilesLifeSpan){
			timer = 0;
			bang.SetActive(true);
			gameObject.SetActive (false);
		}
		if(timer >= projectilesLifeSpan -1){
			bang.SetActive(true);
		}

	
	}

	void OnTriggerEnter (Collider other)
	{
		// If the entering collider is the player...
		if (other.gameObject.tag == "Enemy") {
			//rb.enabled = false;
			// ... the player is in range.
			bang.SetActive(true);
			EnemyHealth enemyHealth; 
			enemyHealth = other.gameObject.GetComponent<EnemyHealth> ();
			enemyHealth.ChangeHealth (healthDamage);
		} 
	}
	void OnEnable(){
		bang.SetActive(false);
	}


}
