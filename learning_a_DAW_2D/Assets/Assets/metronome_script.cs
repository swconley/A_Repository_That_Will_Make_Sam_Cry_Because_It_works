using UnityEngine;
using System.Collections;

public class metronome_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Time.deltaTime*100, 0, 0, Camera.main.transform);
		print (transform.position.x);
		if (transform.position.x >= 1240) {
			print ("this one isn't about heroin");
			transform.position= new Vector3(0,transform.position.y,transform.position.z);
			//transform.Translate(-4500, 0, 0, Camera.main.transform);
			//transform.Translate = (-1581,transform.position.y,transform.position.z);
		}
	}
}
