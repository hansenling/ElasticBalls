using UnityEngine;
using System.Collections;

public class StartSpeed : MonoBehaviour {

	public int xval = 50;
	public int yval = 50;
	public int zval = 50;
	static Vector3 startSpeed;


	//double a =.Range (0.0f, 1.0f);
	//Color startcolor = new Color(r, g, b, 1);
	void Start () {
		float r = Random.value;
		float g = Random.value;
		float b = Random.value;
		int x = Random.Range(-xval, xval);
		int y = Random.Range(-yval, yval);
		int z = Random.Range(-zval, zval);
		startSpeed = new Vector3(x, y, z);
		this.rigidbody.velocity = startSpeed;
		this.transform.localScale = Random.value * this.transform.localScale;
		this.renderer.material.color = new Vector4(r, g, b, 1.0f);


	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) == true){
			Application.Quit ();		
		}
	}
	void OnCollisionEnter(Collision target){
		if (target.gameObject.tag.Equals("Player") == true){
			print(target.gameObject.tag);
			Application.Quit();
	}
}
}
