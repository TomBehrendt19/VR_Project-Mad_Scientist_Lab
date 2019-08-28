using UnityEngine;
using System.Collections;

	public class EnemyMovement : MonoBehaviour
	{
		Transform player;               // Reference to the player's position.
		EnemyHealth enemyHealth;        // Reference to this enemy's health.
		UnityEngine.AI.NavMeshAgent nav;               // Reference to the nav mesh agent.

		
		void Awake ()
		{
			// Set up the references.
			player = GameObject.FindGameObjectWithTag ("Player").transform;
			enemyHealth = GetComponent <EnemyHealth> ();
			nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
		}
		
	public void SetSpeed(float speed){
		nav.speed = speed;
	}
		
	void Update ()
	{
		// If the enemy and the player have health left...
		if(enemyHealth.currentHealth > 0 && nav.isOnNavMesh)
		{
			// ... set the destination of the nav mesh agent to the player.
			nav.SetDestination (player.position);
		}
	}
}