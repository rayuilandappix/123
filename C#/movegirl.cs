using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movegirl : MonoBehaviour {
	public int move;
	public int timenumber;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timenumber++;
		if (timenumber == 15) {
			timenumber = 0;
			if (move == 1) {
				move = 0;
			}else{
				move = 1;
			}
		}
		if (move == 1) {
			this.gameObject.transform.position = new Vector2 (this.gameObject.transform.position.x, 1.85f);
		} else {
			this.gameObject.transform.position=new Vector2 (this.gameObject.transform.position.x, 1.64f);
		}
	}

}
