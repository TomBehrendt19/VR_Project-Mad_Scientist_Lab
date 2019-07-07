using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	AudioSource music;
	float timer = 0.0f;
	public float[] timeStamps;

	// Use this for initialization
	void Start () 
	{
		music = GetComponent<AudioSource> ();
		music.Play ();
	}
	


	void Update()
	{
		timer += Time.deltaTime;
		float seconds = timer % 60;
		if (seconds > timeStamps [0] && seconds < timeStamps [1]) {
			Debug.Log ("Time stamp 1");
		} else if (seconds > timeStamps [1] && seconds < timeStamps [2]){
			Debug.Log ("Time stamp 2");
		}else if (seconds > timeStamps [2] && seconds < timeStamps [3]){
			Debug.Log ("Time stamp 3");
		}else if (seconds > timeStamps [3] && seconds < timeStamps [4]){
			Debug.Log ("Time stamp 4");
		}


	}
}
