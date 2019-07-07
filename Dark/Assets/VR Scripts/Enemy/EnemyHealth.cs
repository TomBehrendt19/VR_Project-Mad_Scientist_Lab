using UnityEngine;

    public class EnemyHealth : MonoBehaviour
    {
		public float startingHealth = 100.0f;		// The amount of health to start with
		public float maxHealth = 100.0f;			// The maximum amount of health
		public float currentHealth = 100.0f;				// The current ammount of health
        public int scoreValue = 2;                 // The amount added to the player's score when the enemy dies.
        public AudioClip deathClip;                 // The sound to play when the enemy dies.
		private bool dead = false;					// Used to make sure the Die() function isn't called twice.
		public bool makeExplosion = false;			// Whether or not an explosion prefab should be instantiated
		public GameObject explosion;				// The explosion prefab to be instantiated

	[HideInInspector]
	public SpawnerManager enemySpawnerScript; 				//Stores a reference to the enemy Spawner Script (This field is populated in the enemy spawn script)


        //Animator anim;                              // Reference to the animator.
        //AudioSource enemyAudio;                     // Reference to the audio source.
        bool isDead;                                // Whether the enemy is dead.
        bool isSinking;                             // Whether the enemy has started sinking through the floor.
		ScoreManager scoreManager;

        void Awake ()
        {
            // Setting up the references.
            //anim = GetComponent <Animator> ();
            //enemyAudio = GetComponent <AudioSource> ();
			enemySpawnerScript = GameObject.Find("Spawner").GetComponent<SpawnerManager>();
			scoreManager = GameObject.Find("ScoreManger").GetComponent<ScoreManager>();
            // Setting the current health when the enemy first spawns.
            currentHealth = startingHealth;
        }
		void OnEnable(){
			currentHealth = startingHealth;
			isDead = false;
			makeExplosion = true;
		}
	public void ChangeHealth(float amount)
	{

		// If the enemy is dead...
		if (isDead) {
			// ... no need to take damage so exit the function.
			return;
		}
		// Change the health by the amount specified in the amount variable
		currentHealth -= amount;
		// If the health runs out, then Die.
		if (currentHealth <= 0 && !dead) {
			Die ();	
		}
	}


    public void Die()
    {
        // This GameObject is officially dead.  This is used to make sure the Die() function isn't called again
        isDead = true;
		DisableGameObject ();

		if (makeExplosion) {
			//Instantiate (explosion, transform.position, transform.rotation);
			GameObject returnedGameObject = PoolManager.current.GetPooledObject(explosion.name);
			if(returnedGameObject == null) return;
			returnedGameObject.transform.position = transform.position;
			returnedGameObject.transform.rotation = transform.rotation;
			returnedGameObject.SetActive(true);
		}
        // Tell the animator that the enemy is dead.
        //anim.SetTrigger("Dead");

        // Change the audio clip of the audio source to the death clip and play it (this will stop the hurt clip playing).
        //enemyAudio.clip = deathClip;
        //enemyAudio.Play();
    }
        
   
	public void DisableGameObject ()
	{		
            // Increase the score by the enemy's score value.
		if (ScoreManager.score < 100) {
			scoreManager.ScoreUpdate (scoreValue);
		}
            // After 2 seconds destory the enemy.
			enemySpawnerScript.enemiesFromThisSpawnerList.Remove(gameObject);
			ScoreManager.enemies.Remove(gameObject);
			currentHealth = startingHealth;
			isDead = false;
			gameObject.SetActive (false);
    }
}