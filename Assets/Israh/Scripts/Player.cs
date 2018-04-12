using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {


	public Text coinCounter;
	public int coinPickups = 0;
	public float speedX = 100;
	public Rigidbody2D rb;
	public GameObject CoinText;
	public float jumpSpeed = 300.0f;
	GameObject Camera;
	float smoothTimeY = 0.1f;
	float smoothTimeX = 0.1f;
	Vector2 spawnPoint;



	public float moveSpeed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		Camera = GameObject.FindGameObjectWithTag("MainCamera");
		coinCounter = CoinText.GetComponent<Text> ();
		coinCounter.text = "0";

	}

	void UpdateCounter()
	{
		coinCounter.text = coinPickups.ToString();
	}



	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Knuffelbeer") {
				DestroyObject (col.gameObject);
				coinPickups = coinPickups + 1;
				coinCounter.text = coinPickups.ToString();
				UpdateCounter();
			}
		if (coinPickups == 8) {
			SceneManager.LoadScene ("menu");
			
		}

	}
	 

	void Update(){
		
		if (Input.GetKey("d")) {
			rb.AddForce(new Vector2((speedX - rb.velocity.x) * Time.deltaTime, 0));
		}
		if (Input.GetKey("a")) {
			rb.AddForce(new Vector2((-speedX - rb.velocity.x) * Time.deltaTime, 0));
		}

		if (gameObject.name == "Player") {
			Vector2 cameraVelocity = new Vector2 ();
			float posX = Mathf.SmoothDamp (Camera.transform.position.x, transform.position.x, ref
			cameraVelocity.x, smoothTimeX);
			float posY = Mathf.SmoothDamp (Camera.transform.position.y, transform.position.y, ref
			cameraVelocity.y, smoothTimeY);
			Camera.transform.position = new Vector3 (posX, posY, Camera.transform.position.z);
		}
	}





	

	void FixedUpdate () {



		if(Input.GetButtonDown("Jump"))
		{
			rb.AddForce(Vector2.up * jumpSpeed);
		}



	}
}
	