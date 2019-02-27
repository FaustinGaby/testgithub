using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alienn : MonoBehaviour {
	mothership myMother;
	public AudioClip deathSound;
	// Use this for initialization
	void Start () {
		myMother = transform.parent.parent.GetComponent<mothership> ();
		
	}

	
	// Update is called once per frame
	void OnDestroy () {
		myMother.CompterAliens ();
		
	}
}
