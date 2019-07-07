using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColour : MonoBehaviour {

	public Renderer colourOne;
	public Renderer colourTwo;
	public Color startColorTop = Color.green;
	public Color startColorBottom = Color.blue;
	public Color finishColorTop = Color.red;
	public Color finishColorBottom = Color.yellow;
	private Color lerpedColorTop;
	private Color lerpedColorBottom;
	private float currentScore = 0;

	// Use this for initialization
	void Start () {

		colourOne.material.SetColor ("_TopColor", startColorTop);
		colourOne.material.SetColor ("_BottomColor", startColorBottom);
		colourTwo.material.SetColor ("_TopColor", startColorTop);
		colourTwo.material.SetColor ("_BottomColor", startColorBottom);

	}
	
	// Update is called once per frame
	public void UpdateColour (float score) {
		if(currentScore != score){
			currentScore = score;
			if(currentScore > 0){
				lerpedColorTop = Color.Lerp(startColorTop, finishColorTop, currentScore / 100);
				lerpedColorBottom = Color.Lerp(startColorBottom, finishColorBottom, currentScore / 100);
				colourOne.material.SetColor ("_TopColor", lerpedColorTop);
				colourOne.material.SetColor ("_BottomColor", lerpedColorBottom);
				colourTwo.material.SetColor ("_TopColor", lerpedColorTop);
				colourTwo.material.SetColor ("_BottomColor", lerpedColorBottom);
			}
		}
	}
}
