using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickonhelp : MonoBehaviour {

	public bool mouseoverhelp = false;

	void OnMouseEnter()
	{
		mouseoverhelp = true;
	}

	void OnMouseExit()
	{
		mouseoverhelp = false;
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (mouseoverhelp == true) {
			if (Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene ("spel");
			}
		}
	}
}
