using UnityEngine;
using System.Collections;

public class add_track_script : MonoBehaviour {
	//Vector3 butPos;

	//float x = -0.06f;
	//float y = 4.0f;
	//float z = 0.0f;
	Vector3 butPos = new Vector3(-0.06f, 2.5f, 0.0f);

	// Use this for initialization
	void Start () {
		//float x = -0.06f;
		//float y = 3.0f;
		//float z = 0.0f;
		//butPos = new Vector3(x, y, z);
	}
	
	// Update is called once per frame
	void Update () {
		//onMouseDown ();
	}

	void OnMouseDown(){
		print ("Sam hates heroin");
		var newTrack = GameObject.Find("Track_prefab");
//		Quaternion rot = new Quaternion ();
		if (newTrack != null) {
			print ("Sam only likes heroin as a friend");
			Instantiate(newTrack, butPos, Quaternion.identity);
			butPos.y -= 2;
		}
	}
}
