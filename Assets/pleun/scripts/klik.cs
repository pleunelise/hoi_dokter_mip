using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klik : MonoBehaviour {
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (mouseWorldPos, Vector2.zero);
			if (hit == null) {
				return;
			}
			if (hit.transform == null) {
				return;
			}

			Debug.Log ("Hit Collider: " + hit.transform.name);

			switch (hit.transform.name) {
			case "Bureaustoel":
				animator.Play ("gevstoel");
				Destroy("Bureaustoel");
				break;
			case "Prikbord-2":
				animator.Play ("gevPrikbord");
				break;	
			case "Plant":
				animator.Play ("gevPlent");
				break;
			case "Ladekast":
				animator.Play ("gevKast");
				break;
			case "Receptiebordje":
				animator.Play ("gevBordje");
				break;
			case "Computer":
				animator.Play ("gevondenAnimatie");
				break;
			}
		}
	}
}

