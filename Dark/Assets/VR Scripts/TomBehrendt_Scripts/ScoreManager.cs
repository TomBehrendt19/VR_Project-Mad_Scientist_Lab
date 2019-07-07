using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic; // Required when Using Lists.

public class ScoreManager : MonoBehaviour
{
    public static float score;        // The player's score.
	public Slider scoreSlider;
	private GameObject player;
	PlayerShootProjectile playerShootProjectile;
	//EnemyMovement enemyMovement;
	private GameObject spawnerManger;
	private Autowalk autoWalk;
	public static List<GameObject> enemies = new List<GameObject> (); //List for waypoints
	public GameObject gameOver;
	public Image sliderImage;

	AudioSource music;
	float timer = 0.0f;
	public float[] timeStamps;

    void Awake()
    {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerShootProjectile = player.GetComponentInChildren<PlayerShootProjectile> ();
		autoWalk = player.GetComponent<Autowalk> ();
		spawnerManger = GameObject.Find("Spawner");
		scoreSlider.value = 0;
		ScoreUpdate (0);
		music = GetComponent<AudioSource> ();
		music.Play ();

    }
		

	void Update()
	{
		timer += Time.deltaTime;
		float seconds = timer;

		if (seconds > timeStamps [0] && seconds < timeStamps [1]) {
			//Debug.Log ("T1 " + seconds);
			EnemySpeed (2);
		} else if (seconds > timeStamps [1] && seconds < timeStamps [2]){
			//Debug.Log ("T2 " + seconds);
			EnemySpeed (4);
		}else if (seconds > timeStamps [2] && seconds < timeStamps [3]){
			//Debug.Log ("T3 " + seconds);
			EnemySpeed (6);
		}else if (seconds > timeStamps [3] && seconds < timeStamps [4]){
			//Debug.Log ("T4 " + seconds);
			EnemySpeed (8);
		}


	}

	void EnemySpeed(int speed){
		for(int i=0; i < enemies.Count; i++){
			//Debug.Log (enemies.Count);
			enemies[(i)].GetComponent<EnemyMovement>().SetSpeed( speed );
			//enemies[(i)].GetComponent<EnemyColour>().UpdateColour( score );
		}
	}


	public void ScoreUpdate(float amountToModifyScoreBy)
    {
		
		score += amountToModifyScoreBy;
		//scoreSlider.value = score;
		sliderImage.color = Color.Lerp(Color.white, Color.red, score / 100);

		//if (score >= 100) {
			//GameOver ();
		//}

		//PlayerShootProjectile.timeBetweenProjectiles = 2.4f - (score / 100);

		for(int i=0; i < enemies.Count; i++){
			//Debug.Log (enemies.Count);
			//enemies[(i)].GetComponent<EnemyMovement>().SetSpeed( 1 + score/10 );
			//enemies[(i)].GetComponent<EnemyColour>().UpdateColour( score );
		}
		//Debug.Log (PlayerShootProjectile.timeBetweenProjectiles);
		//Debug.Log (score);


    }

	void GameOver (){
		for(int i=0; i < enemies.Count; i++){
			enemies [(i)].SetActive (false);
		}
		spawnerManger.SetActive(false);
		playerShootProjectile.enabled = false;
		gameOver.SetActive (true);
		autoWalk.enabled = false;
	}

	void ResetGame (){
		spawnerManger.SetActive(true);
		playerShootProjectile.enabled = true;
		gameOver.SetActive (false);
		score = 0;
		autoWalk.enabled = true;
	}

}

