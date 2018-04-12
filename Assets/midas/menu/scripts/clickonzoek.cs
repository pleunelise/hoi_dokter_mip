using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickonzoek : MonoBehaviour {

	public bool mouseoverzoek = false;

	void OnMouseEnter()
	{
		mouseoverzoek = true;
	}

	void OnMouseExit()
	{
		mouseoverzoek = false;
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (mouseoverzoek == true) {
			if (Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene ("Israh");
			}
		}

	}
}
