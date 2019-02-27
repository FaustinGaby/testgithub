using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathwall : MonoBehaviour {

	void OnTriggerExit(Collider objetTouche)
	{
		Destroy(objetTouche.transform.parent.gameObject);	
	}
		

}
