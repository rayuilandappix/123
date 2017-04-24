using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbiggerandfly : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate(new Vector2 (0,0.06f));
		this.gameObject.transform.localScale =new Vector3 (0.04f+ this.gameObject.transform.localScale.x,0.04f+ this.gameObject.transform.localScale.y,this.gameObject.transform.localScale.z);
		if(this.gameObject.transform.position.y>6){
			GameObject getpoint = GameObject.Find ("getpoint");
			getpoint.SendMessage ("ggover", 1, SendMessageOptions.DontRequireReceiver);
			Destroy(this.gameObject);
		}
	}

	/*void OnMouseDown(){
		GameObject getpoint = GameObject.Find ("getpoint");
		getpoint.SendMessage ("getnumber", 1, SendMessageOptions.DontRequireReceiver);
		Destroy(this.gameObject);

	}*/

}
