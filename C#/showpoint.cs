using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showpoint : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		text.text = PlayerPrefs.GetString ("_Point");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
