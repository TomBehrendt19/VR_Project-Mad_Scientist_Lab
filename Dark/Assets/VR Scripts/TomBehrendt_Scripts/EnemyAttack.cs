using UnityEngine;
using System.Collections;

namespace CompleteProject
{
	public class EnemyAttack : MonoBehaviour
	{
		public int healthDamage = 10;               // The amount of health taken away per attack.
		GameObject player;                          // Reference to the player GameObject.
		PlayerHealth playerHealth;                  // Reference to the player's health.
		EnemyHealth enemyHealth;                    // Reference to this enemy's health.

		void Awake ()
		{
			// Setting up the references.
			player = GameObject.FindGameObjectWithTag ("Player");
			playerHealth = player.GetComponent <PlayerHealth> ();
			enemyHealth = GetComponent<EnemyHealth>();
		}
		
		void OnTriggerEnter (Collider other)
		{
			// If the entering collider is the player...
			if(other.gameObject.tag == "Player")
			{
				// ... the player is in range.
				enemyHealth.ChangeHealth(100);
				enemyHealth.makeExplosion = false;
				playerHealth.TakeDamage(healthDamage);
			}
		}
	}
}