using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour {

	public Light sun;
	public bool sunOn;

	public void EventMessage ()
	{
		Debug.Log ("Hi, I'm a animation event");
	}

	public void Sunlight()
	{
		sunOn = !sunOn;
		if (sunOn)
			sun.enabled = true;
		else
			sun.enabled = false;
	}
}
