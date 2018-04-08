using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickonwheelchair : MonoBehaviour {


	public bool wheelchair_mouseover = false;

	public bool wheelchairIsClicked = false;





	void OnMouseEnter(){
		wheelchair_mouseover = true;
	}


	void OnMouseExit(){
		wheelchair_mouseover = false;
	}




	void Update () {
		if (wheelchair_mouseover == true) {
			if (Input.GetMouseButtonDown (0)) {
				wheelchairIsClicked = true;
			} else {
				wheelchairIsClicked = false;
			}
		}
	}

}
