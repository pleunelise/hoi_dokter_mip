using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makehumans : MonoBehaviour {

	public bool first = false;

	public int[] counter;

	public int people;

	public float seconds, minutes;

	public int sec, min, secSS;

	public int rand_sign;


	public GameObject bg;

	public GameObject doctor;


	void Start () {

		bg = GameObject.Find ("bg");


		rand_sign = Random.Range (1,4);
		Debug.Log (rand_sign);


	}

	public void spawn(int people){
		for (int i = 1; i <= people; i++) {
			Instantiate (doctor, new Vector3 (0f, 4f, -0.3f), transform.rotation);
		}
	}



	void Update () {

		minutes = (int)(Time.time / 60f);
		seconds = (int)(Time.time % 60);

		sec = (int)seconds;
		min = (int)minutes;

		secSS =(int)min * 60 + sec;


		if (secSS % 10 == 0) {
			
			if (first == false) {
				people = (int)((secSS + 10) / 10);
				spawn (people);
			}

			first = true;


		} else {
			first = false;

		}

	}
}
