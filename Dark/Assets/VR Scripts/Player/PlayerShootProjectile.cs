//Dan Check 3
using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(AudioSource))]
public class PlayerShootProjectile : MonoBehaviour {

	//Setup
	private AudioSource projectileAudioSource;

	//Settings
	public static float timeBetweenProjectiles = 1.1f; //Fire delay between shots
	public GameObject projectilePrefab;
	public int launchForce = 20;
	public AudioClip projectileAudio;
	public float audioVolume = 0.4f;

	//Projectile Name
	private string projectileType; //Holds the name of the projectile
	
	//Timer
	private float timer;
	
	void Awake ()
	{
		projectileAudioSource = GetComponent<AudioSource> ();
		projectileType = projectilePrefab.name;
	}
	
	
	void FixedUpdate ()
	{
		//Controls when the projectile is fired
		timer += Time.fixedDeltaTime;

		//If enought time has passed shoot
		if(timer >= timeBetweenProjectiles){
			Shoot ();
		}

	}

		
	//Shoots the Projectile
	void Shoot (){
		if(projectilePrefab){
			timer = 0f;	//Resets timer
			//Audio
			projectileAudioSource.volume = audioVolume;
			projectileAudioSource.clip = projectileAudio;
			projectileAudioSource.Play();
			//Returns the an unsed object from the pooler
			GameObject returnedGameObject = PoolManager.current.GetPooledObject(projectileType);
			if(returnedGameObject == null) return;
			returnedGameObject.transform.position = transform.position;
			returnedGameObject.transform.rotation = transform.rotation;
			returnedGameObject.SetActive(true);
			returnedGameObject.transform.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			returnedGameObject.transform.GetComponent<Rigidbody>().AddForce(returnedGameObject.transform.forward * launchForce, ForceMode.Impulse);

		}
	}
}