using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickonheart : MonoBehaviour {



	public bool heart_mouseover = false;

	public bool heartIsClicked = false;





	void OnMouseEnter(){
		heart_mouseover = true;
	}


	void OnMouseExit(){
		heart_mouseover = false;
	}




	void Update () {
		if (heart_mouseover == true) {
			if (Input.GetMouseButtonDown (0)) {
				heartIsClicked = true;
			} else {
				heartIsClicked = false;
			}
		}
	}


}
