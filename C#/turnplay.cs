using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class turnplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Loadplay()
	{
		float m_timer = 0;
		while (m_timer >= 7) {
			m_timer += Time.time;
		}
		SceneManager.LoadScene ("play");
	}
}
