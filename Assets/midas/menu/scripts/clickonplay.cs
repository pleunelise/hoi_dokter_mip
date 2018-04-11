using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickonplay : MonoBehaviour {

	public bool mouseoverplay = false;

	void OnMouseEnter()
	{
		mouseoverplay = true;
	}

	void OnMouseExit()
	{
		mouseoverplay = false;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (mouseoverplay == true) {
			if (Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene ("select");
			}	
		}
	}
}
