using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickonbliep : MonoBehaviour {



	public bool bliep_mouseover = false;

	public bool bliepIsClicked = false;





	void OnMouseEnter(){
		bliep_mouseover = true;
	}


	void OnMouseExit(){
		bliep_mouseover = false;
	}




	void Update () {
		if (bliep_mouseover == true) {
			if (Input.GetMouseButton (0)) {
				bliepIsClicked = true;
			} else {
				bliepIsClicked = false;
			}
		}
	}

}
