using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaisseau : MonoBehaviour
{
	
	public Rigidbody vaisseauRb;
	public float vitesse;

	public GameObject missile;
	GameObject missileOnScreen;




	void FixedUpdate ()
	{

		if (Input.GetAxis ("Horizontal") != 0)
		{ // si on appuie sur une fleche gauche ou droite
			// On calculs la nouvelle position desiree du baisseau
			 Vector3 newPosition = transform.position + new Vector3 (Input.GetAxis ("Horizontal")* vitesse, 0, 0);
			 vaisseauRb.MovePosition (newPosition);
		}
		else
		{
			vaisseauRb.velocity = Vector3.zero; //on stop le vaisseau
		}
	}

		void Update ()
		{ 
			if (Input.GetButtonDown ("Jump") && missileOnScreen == null)
			{
				missileOnScreen = Instantiate (missile, transform.position, transform.rotation);
			}
		}


}

