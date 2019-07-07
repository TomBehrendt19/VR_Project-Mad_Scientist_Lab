//Dan Check
using UnityEngine;
using System.Collections;
using System.Collections.Generic; // needed to use lists

public class SpawnerManager : MonoBehaviour
{
	//Settings
	public float spawnTime;														//Spawn time
	public GameObject[] enemyPrefabs;											//Enemey Prefabs
	public int maxNumberOfEnemiesAtOneTime = 8;									//Holds the max number of enemies allowed at anyone time
	public int distancePlayerMustBeFromSpawnerBeforeSpawnerInstantiates = 15;	
	//Lists
	private List<Transform> spawnPoints = new List<Transform>();		 		//List for spawnpoints
	[HideInInspector] // Hides var below	
	public List<GameObject> enemiesFromThisSpawnerList = new List<GameObject>();//List for enemies this spawner has created that are still alive

	//General
	private int enemycount;														//Number of enemies in the current world
	private GameObject player;													//The player
	private bool enableSpawner = true;
	private int lastSpawnPoint;
	int randomSpawnPoint;
	int selectEnemyPrefab;

	void Start ()
	{
		SetUpChildObjects ();	//Checks and setup child elements in the spawner

		player = GameObject.FindGameObjectWithTag("Player");
		// Call the checkIfObjectShouldBeSpawned function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("checkIfObjectShouldBeSpawned", spawnTime, spawnTime);

	}
	//Checks and setup child elements in the spawner
	void SetUpChildObjects ()
	{
		//Adds Spawn Points and Waypoints to there appropriate lists
		foreach (Transform child in transform)
		{
			if(child.tag == "SpawnPoint")
			{
				spawnPoints.Add(child);
			}
		}

	}

	//Checks if a object should be spawned
	void checkIfObjectShouldBeSpawned(){
		//Allows us to disable and enable the spawner
		if(enableSpawner == true){

			//If we have not reach the limt of enemies from this spawner
			if(enemiesFromThisSpawnerList.Count < maxNumberOfEnemiesAtOneTime){
				EnemySetActive();
			}
		}
	}
	
	//When this functions is called a Enemey is Instantiated
	void EnemySetActive()
	{
		randomSpawnPoint = Random.Range(0,spawnPoints.Count);

		int i = 0;
		//If the distance between the spawn position and the player positon is bigger than 15
		while (Vector3.Distance(spawnPoints[randomSpawnPoint].position,player.transform.position) < distancePlayerMustBeFromSpawnerBeforeSpawnerInstantiates || i >= spawnPoints.Count)
		{
			randomSpawnPoint = Random.Range(0,spawnPoints.Count);
		}


		    selectEnemyPrefab = 0;
			//Set a to a random spawn position
			selectEnemyPrefab = Random.Range(0,enemyPrefabs.Length);

			//Request an avaliable enemy from the pooling manager
			GameObject returnedGameObject = PoolManager.current.GetPooledObject(enemyPrefabs[selectEnemyPrefab].name);
			if(returnedGameObject == null) return;
			returnedGameObject.transform.position = spawnPoints[randomSpawnPoint].position;
			returnedGameObject.transform.rotation = spawnPoints[randomSpawnPoint].rotation;
			ScoreManager.enemies.Add(returnedGameObject);

			//Loads a reference to the EnemySpawner Script into the health script so that we can remove objects from the list when they die
			//EnemyHealth enemyhealth = returnedGameObject.GetComponent<EnemyHealth>();
			//enemyhealth.enemySpawnerScript = GetComponent<SpawnerManager>();

			returnedGameObject.SetActive(true);

			//Allows us to track the number of enemies currently alive
			enemiesFromThisSpawnerList.Add(returnedGameObject); //Adds enemy count to the enemiesFromThisSpawnerList so that we can keep track of how many enemies are in this scene that this spawner has created
			//////////Removes the enemy from the main enemy list in the GameControler
			//GameController.gameController.enemies.Add(returnedGameObject);
			//////////Removes the enemy from the main enemy list in the GameControler
		}

	void OnDisable(){
		CancelInvoke ("checkIfObjectShouldBeSpawned");
	}
}
	
