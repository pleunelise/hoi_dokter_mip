using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoi : MonoBehaviour {

	private float[] noiseValues;

	public GameObject Heart;
	public GameObject WheelChair;
	public GameObject StethoScope;
	public GameObject Bliep;

	public float X_vel = 200;
	public int randDoctorState; 
	public float Y_vel = 0;
	public Rigidbody2D rb;
	public GameObject U_gate;


	IEnumerator GoMove(Vector2 MPos, float speed){
		bool done = false;
		while (done == false){

			float step = speed * Time.deltaTime;

			transform.position = Vector2.MoveTowards (transform.position, MPos, step);

			if (new Vector2 (transform.position.x, transform.position.y) == MPos) {
				done = true;
			}
			yield return new WaitForSeconds (Time.deltaTime);
		}
	}

	void OnCollisionEnter (Collision2D coll){
		return;
	}



	public void MoveTo (Vector2 MPos, float speed) {
		StartCoroutine(GoMove(MPos, speed));
	}
		

	void Start () {
		U_gate = GameObject.Find ("upper_gate");
		Heart = GameObject.Find ("heart");
		Bliep = GameObject.Find ("bliep");
		StethoScope = GameObject.Find ("stethoscope");
		WheelChair = GameObject.Find ("wheelchair");
		transform.position = new Vector2 (U_gate.transform.position.x, U_gate.transform.position.y);
		randDoctorState = (int)Mathf.Floor(Random.Range(1f, 5));
	}
					
	void FixedUpdate () {
		if (randDoctorState == 1) {
			MoveTo (Heart.transform.position, 0.5f);
		} else if (randDoctorState == 2) {
			MoveTo (Bliep.transform.position, 0.5f);
		} else if (randDoctorState == 3) {
			MoveTo (StethoScope.transform.position, 0.5f);
		} else {
			MoveTo (WheelChair.transform.position, 0.5f);
		}

	}
}
