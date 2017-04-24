using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showherat : MonoBehaviour {
	int showh;
	int rund;
	public AudioSource[] music;
	// Use this for initialization
	public int rangebig;
	public int rangesml;
	void Start () {
		rangebig = 240;
		rangesml = 40;
	}

	// Update is called once per frame
	void Update () {
		if (rund == 0) {
			rund = Random.Range (rangesml, rangebig);
		}
		showh++;
		if (showh == rund) {
			rund = Random.Range (0, 1000);
			GameObject ht = (GameObject)Resources.Load ("Prefabs/heart");
			if (rund < 330) {
				music [0].Play ();
				 ht = (GameObject)Resources.Load ("Prefabs/heart");
			} else if (rund < 660) {
				music [1].Play ();
				 ht = (GameObject)Resources.Load ("Prefabs/star");
			} else {
				music [2].Play ();
				 ht = (GameObject)Resources.Load ("Prefabs/music");
			}
			GameObject hear = GameObject.Find("hear");  
			ht = Instantiate (ht);
			ht.transform.parent = hear.transform;  	
			showh = 0;
			rund = 0;
		}
	}

	void gethard(int number){
		if (rangebig > 35) {
			rangebig -= 25;
		}
		if (rangesml > 20) {
			rangesml -= 15;
		}
	}
}
