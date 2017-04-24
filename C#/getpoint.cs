using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getpoint : MonoBehaviour {
	public Text text;
	public int point;
	public int hard;
	public GameObject hardone;
	// Use this for initialization
	void Start () {
		hard = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void getnumber (int number)
	{
		point+=10;
		text.text = "Score:" + point;
		if (point / 50 > hard) {
			hard++;
			hardone.SendMessage ("gethard", 1, SendMessageOptions.DontRequireReceiver);
		}
	}

	void ggover(int number)
	{
		PlayerPrefs.SetString ("_Point","Score:"+point);
		SceneManager.LoadScene ("gameover");
	}
}
