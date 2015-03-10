using UnityEngine;
using System.Collections;

public class BallGenerator : MonoBehaviour {
	public double myTimerStart = 1.0f;
	static double myTimer;
	public Transform ball;
	void Start () {
		myTimer = myTimerStart;
	}

	void Update () {
		myTimer -= Time.deltaTime;
		if (myTimer < 0.0f){
			Instantiate(ball, this.transform.position,  Quaternion.identity);
			myTimer = myTimerStart;
		}
	}
}
