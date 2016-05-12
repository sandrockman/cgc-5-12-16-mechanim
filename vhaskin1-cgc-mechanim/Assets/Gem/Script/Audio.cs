using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {
	

	public AudioSource aud;
	public Animator anim;

	void Update ()
	{
	
		if (Input.GetButtonDown ("Fire1"))
			anim.SetTrigger ("collect");
	}

	public void Pop ()
	{
		aud.Play ();
		Destroy (gameObject, 2f);
	}
}
