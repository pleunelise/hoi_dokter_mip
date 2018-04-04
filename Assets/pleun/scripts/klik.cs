using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klik : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(mouseWorldPos, Vector2.zero);
			anim.Play("");
			if(hit != null){
				Debug.Log("Hit Collider: " + hit.transform.name);
			}
			else {
				Debug.Log("No colliders hit from mouse click");
			}
		}
	}

	//void OnMouseDown(){
	//	Debug.Log ("Clicked!");
	//}
}
