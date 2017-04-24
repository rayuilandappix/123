using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class button : MonoBehaviour {
	public string chose;
	public AudioSource music;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnExit(){
		if (GameObject.FindWithTag (chose)) {
			music.Play ();
			GameObject heart = GameObject.FindWithTag (chose);
			GameObject getpoint = GameObject.Find ("getpoint");
			getpoint.SendMessage ("getnumber", 1, SendMessageOptions.DontRequireReceiver);
			Destroy (heart);
		} else {
			GameObject getpoint = GameObject.Find ("getpoint");
			getpoint.SendMessage ("ggover", 1, SendMessageOptions.DontRequireReceiver);
		
		}
	}
}
