using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour {
	public float timeToDisable = 1;
	// Use this for initialization
	void OnEnable () {
		Invoke("DisableThisObject", timeToDisable);
	}
	void OnDisable () {
		CancelInvoke("DisableThisObject");
	}
	void DisableThisObject(){
		gameObject.SetActive(false);
	}
}
