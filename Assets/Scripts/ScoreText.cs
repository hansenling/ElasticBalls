using UnityEngine;
using System.Collections;

public class ScoreText : MonoBehaviour {
	static float score;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime;
		int displayScore = ((int)score);
		this.guiText.text = "Score: " + displayScore;
	}
}
