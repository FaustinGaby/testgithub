using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {
	public float vitesse;


	void Start () 
	{

		GetComponent<Rigidbody> ().AddForce (0, vitesse, 0, ForceMode.VelocityChange);
	}
	

	void OnTriggerEnter(Collider objetTouche)
	{
		if (vitesse > 0) {
			if (objetTouche.tag == "ALIEN") {
				Destroy (objetTouche.gameObject);
				Destroy (this.gameObject);
			}
		
		}
		if (vitesse < 0) {
			if (objetTouche.tag == "Player") { 
				Destroy (objetTouche.gameObject);
				Destroy (this.gameObject);
			}
		}
	}
}
	