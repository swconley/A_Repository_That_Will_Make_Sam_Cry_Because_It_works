using UnityEngine;
using System.Collections;

public class add_track_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//onMouseDown ();
	}

	void OnMouseDown(){
		print ("Sam hates heroin");
		var newTrack = GameObject.Find("Track_prefab");
		float x = -0.06f;
		float y = 3.0f;
		float z = 0.0f;
		Vector3 pos = new Vector3(x, y, z);
//		Quaternion rot = new Quaternion ();
		if (newTrack != null) {
			print ("Sam only likes heroin as a friend");
			Instantiate(newTrack, pos, Quaternion.identity);
		}
	}
}
