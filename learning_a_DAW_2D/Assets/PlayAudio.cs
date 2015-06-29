using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PlayAudio : MonoBehaviour {
	public AudioClip[] g;//
	public float semitone_offset = 0;
	// Use this for initialization
	void Start () {
		//AudioSource.PlayClipAtPoint(g[0], transform.position); ////////////
	}
	
	// Update is called once per frame
	void Update () {
		//OnMouseDown ();
	}

	void OnMouseDown(){
		PlayNote();
		//AudioSource.PlayClipAtPoint(g[1], transform.position); ////////////
	}

	void OnCollisionEnter (Collision collision){
		//AudioSource.PlayClipAtPoint(g[1],transform.position,0.5f);
	}
	void PlayNote(){
		AudioSource.PlayClipAtPoint(g[1], transform.position); ////////////
		GetComponent<AudioSource>().pitch = Mathf.Pow(2f, semitone_offset/12.0f);
		GetComponent<AudioSource>().Play();
	}
}
