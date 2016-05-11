using UnityEngine;
using System.Collections;

public class MecanimControl : MonoBehaviour {

	public Animator anim;
	public Event eventScript;

	// Use this for initialization
	void Start () {

		//anim = GetComponent<Animator> ();

	
	}
	
	// Update is called once per frame
	void Update () {

		Circle ();
		Rotate ();
		Jump ();
		Wave ();
	}


	void Rotate ()
	{
		if (Input.GetButtonDown ("Fire1"))
			anim.SetBool ("isRotated", true);
		

		if(Input.GetButtonDown("Fire2"))
			anim.SetBool("isRotated", false);
	}

	void Circle ()
	{
		if (Input.GetKeyDown (KeyCode.A))
			anim.SetInteger ("Circling", 1);
				
	    if (Input.GetKeyDown (KeyCode.D))
			anim.SetInteger ("Circling", 2);
		
	}

	void Jump ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		   anim.SetTrigger ("Jumping");	
	}

	void Wave ()
	{
		if (Input.GetKeyDown (KeyCode.W))
			anim.SetFloat ("Waving", 0.2f);
		if (Input.GetKeyDown (KeyCode.S))
			anim.SetFloat ("Waving", -0.2f);
		
	
	}
}

