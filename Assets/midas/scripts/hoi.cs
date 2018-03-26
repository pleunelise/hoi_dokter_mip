using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoi : MonoBehaviour {

	public float X_vel = 200;
	public float Y_vel = 0;
	public Rigidbody2D rb;



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


	public void MoveTo (Vector2 MPos, float speed) {
		StartCoroutine(GoMove(MPos, speed));
	}
		

	void Start () {

	}

	void FixedUpdate () {
		if (Input.GetMouseButton(0)) {
			MoveTo (new Vector2 (2, 3), 0.5f);
		} else {
			MoveTo (new Vector2 (-3, -3), 0.5f);
		}
	}
}
