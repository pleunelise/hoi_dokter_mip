using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makehumans : MonoBehaviour {

	public int[] counter;

	public int people;

	public float seconds, minutes;

	public int sec, min;


	public GameObject bg;

	public GameObject doctor;

	public GameObject U_gate;


	// Use this for initialization
	void Start () {

		bg = GameObject.Find ("bg");

		U_gate = GameObject.Find ("upper_gate");


	}

	public void waitfor (int time) {
		StartCoroutine(wait(time));
	}

	IEnumerator wait(int time){

		yield return new WaitForSeconds (time);
		
	}

	// Update is called once per frame
	void Update () {

		minutes = (int)(Time.time / 60f);
		seconds = (int)(Time.time % 60);

		sec = (int)seconds;
		min = (int)minutes;

		min = min * 60;

		people = (sec + min + 5 % 5);

		for (int i = 1; i <= people; i++) {
			Instantiate (doctor, U_gate.transform.position, U_gate.transform.rotation);
		}

		waitfor (5);
	}
}
