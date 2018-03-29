using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makehumans : MonoBehaviour {

	public GameObject doctor;

	public GameObject U_gate;


	// Use this for initialization
	void Start () {
		U_gate = GameObject.Find ("upper_gate");

		GameObject doctor = Instantiate(Resources.Load("doctor")) as GameObject; 

		doctor.transform.position = U_gate.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
