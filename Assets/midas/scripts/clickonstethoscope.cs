using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickonstethoscope : MonoBehaviour {



	public bool stethoscope_mouseover = false;

	public bool stethoscopeIsClicked = false;





	void OnMouseEnter(){
		stethoscope_mouseover = true;
	}


	void OnMouseExit(){
		stethoscope_mouseover = false;
	}




	void Update () {
		if (stethoscope_mouseover == true) {
			if (Input.GetMouseButtonDown (0)) {
				stethoscopeIsClicked = true;
			} else {
				stethoscopeIsClicked = false;
			}
		}
	}

}
