using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class hoi : MonoBehaviour {

	public int score = 0;
	public int wrong = 0;
	public Text Score_text;
	public Text Wrong_text;
	public GameObject scoreText;
	public GameObject wrongText;

	public bool dirgiven = false;

	public clickonwheelchair ClickOnWheelchair;
	public clickonstethoscope ClickOnStethoscope;
	public clickonbliep ClickOnBliep;
	public clickonheart ClickOnHeart;


	private bool heartmove = false;
	private bool bliepmove = false;
	private bool stethoscopemove = false;
	private bool wheelchairmove = false;


	public bool mouse_over = false;
	public bool move = false;


	public GameObject Heart;
	public GameObject WheelChair;
	public GameObject StethoScope;
	public GameObject Bliep;

	public int randDoctorState;

	public Rigidbody2D rb;


	IEnumerator GoMove(Vector2 MPos, float speed)
	{
		bool done = false;
		while (done == false)
		{

			float step = speed * Time.deltaTime;

			transform.position = Vector2.MoveTowards (transform.position, MPos, step);

			if (new Vector2 (transform.position.x, transform.position.y) == MPos) 
			{
				done = true;
			}
			yield return new WaitForSeconds (Time.deltaTime);
		}
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (randDoctorState == 1) 
		{
			if (coll.gameObject.tag == "heart") 
			{
				score += 1;
				Score_text.text = "score: " + score.ToString();
				Destroy (gameObject);

			} else if (coll.gameObject.tag == "bliep" || coll.gameObject.tag == "stethoscope" || coll.gameObject.tag == "wheelchair")
			{
				wrong += 1;
				Wrong_text.text = "Wrong: " + wrong.ToString ();
				Destroy (gameObject);

			}
		} else if (randDoctorState == 2)
		{
			if (coll.gameObject.tag == "bliep") 
			{
				score += 1;
				Score_text.text = "score: " + score.ToString();
				Destroy (gameObject);

			} else if (coll.gameObject.tag == "heart" || coll.gameObject.tag == "stethoscope" || coll.gameObject.tag == "wheelchair")
			{
				wrong += 1;
				Wrong_text.text = "Wrong: " + wrong.ToString ();
				Destroy (gameObject);

			}
		} else if (randDoctorState == 3)
		{
			if (coll.gameObject.tag == "stethoscope") 
			{
				score += 1;
				Score_text.text = "score: " + score.ToString();
				Destroy (gameObject);

			} else if (coll.gameObject.tag == "bliep" || coll.gameObject.tag == "heart" || coll.gameObject.tag == "wheelchair")
			{
				wrong += 1;
				Wrong_text.text = "Wrong: " + wrong.ToString ();
				Destroy (gameObject);

			}
		} else if (randDoctorState == 4)
		{
			if (coll.gameObject.tag == "wheelchair") 
			{
				score += 1;
				Score_text.text = "score: " + score.ToString();
				Destroy (gameObject);

			} else if (coll.gameObject.tag == "bliep" || coll.gameObject.tag == "stethoscope" || coll.gameObject.tag == "heart")
			{
				wrong += 1;
				Wrong_text.text = "Wrong: " + wrong.ToString ();
				Destroy (gameObject);

			}
		}
	}


	void OnMouseEnter()
	{
		mouse_over = true;
	}

	void OnMouseExit()
	{
		mouse_over = false;
	}


	public void MoveTo (Vector2 MPos, float speed) 
	{
		StartCoroutine(GoMove(MPos, speed));
	}

	IEnumerator waitoneframe(){
		yield return 0;
	}

	void Start ()
	{
		StartCoroutine (waitoneframe());

		// gets all game objects
		scoreText = GameObject.Find("ScoreText");
		wrongText = GameObject.Find ("WrongText");
		Heart = GameObject.Find ("heart");
		Bliep = GameObject.Find ("bliep");
		StethoScope = GameObject.Find ("stethoscope");
		WheelChair = GameObject.Find ("wheelchair");

		// get gamobjects scripts
		clickonheart ClickOnHeart = Heart.GetComponent<clickonheart> ();
		clickonbliep ClickOnBliep = Bliep.GetComponent<clickonbliep> ();
		clickonstethoscope ClickOnStethoscope = StethoScope.GetComponent<clickonstethoscope> ();
		clickonwheelchair ClickOnWheelchair = WheelChair.GetComponent<clickonwheelchair> ();

		// gives a random nummber to doctor
		randDoctorState = (int)Mathf.Floor(Random.Range(1f, 5));

		Score_text = scoreText.GetComponent<Text> () as Text;
		Wrong_text = wrongText.GetComponent<Text> () as Text;

	}


	void Update()
	{
		clickonheart ClickOnHeart = Heart.GetComponent<clickonheart> ();
		clickonbliep ClickOnBliep = Bliep.GetComponent<clickonbliep> ();
		clickonstethoscope ClickOnStethoscope = StethoScope.GetComponent<clickonstethoscope> ();
		clickonwheelchair ClickOnWheelchair = WheelChair.GetComponent<clickonwheelchair> ();

		if (dirgiven == false)
		{
			if (move == true) 
			{
				if (Input.GetMouseButtonDown (0)) 
				{

					if (ClickOnHeart.heartIsClicked == true) 
					{

						heartmove = true;
						dirgiven = true;

					} else if (ClickOnStethoscope.stethoscopeIsClicked == true) 
					{

						stethoscopemove = true;
						dirgiven = true;

					} else if (ClickOnBliep.bliepIsClicked == true) 
					{

						bliepmove = true;
						dirgiven = true;

					} else if (ClickOnWheelchair.wheelchairIsClicked == true) 
					{

						wheelchairmove = true;
						dirgiven = true;

					}
				}
			}
		}


		if (mouse_over == true) 
		{
			if (Input.GetMouseButtonDown (0)) 
			{
				move = true;
			}
		}


		if (wrong > 3) {
			return;
		}
			
	}

	void FixedUpdate ()
	{

		if (move == true) 
		{
			if (heartmove == true) 
			{
				MoveTo (Heart.transform.position, 0.5f);
			} else if (bliepmove == true) 
			{
				MoveTo (Bliep.transform.position, 0.5f);
			} else if (stethoscopemove == true)
			{
				MoveTo (StethoScope.transform.position, 0.5f);
			} else if (wheelchairmove == true)
			{
				MoveTo (WheelChair.transform.position, 0.5f);
			}
		}

	}

}
