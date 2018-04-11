using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickonreceptie : MonoBehaviour {

	public bool mouseoverreceptie = false;

	void OnMouseEnter()
	{
		mouseoverreceptie = true;
	}

	void OnMouseExit()
	{
		mouseoverreceptie = false;
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (mouseoverreceptie == true) {
			if (Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene ("receptie");
			}
		}
	}
}
