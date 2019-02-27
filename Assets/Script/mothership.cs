using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mothership : MonoBehaviour {

	public static int aliensEnVie;
	public static float sens;

	public Rigidbody mothershipRb;	
	public float moveStep;
    float Delay;
	public float verticalStep;
	public float startDelay;




	void Start () 
	{
		 CompterAliens ();
		sens = 1f;
		BougerAliens ();
		Invoke ("Tirer", 3f);

	}

	public void CompterAliens()
	{
		 aliensEnVie = GameObject.FindGameObjectsWithTag ("ALIEN").Length;
		if (aliensEnVie < 1)
			Victory ();
	}

	void BougerAliens()
	{
		Debug.Log ("ON DESCEEEEEEND");
		mothershipRb.MovePosition (transform.position + new Vector3 (moveStep * sens, 0, 0 ) );
		Invoke ("BougerAliens", Delay);
		Delay = startDelay - ((55f - aliensEnVie)/125f);
	}

	void Descendre()
	{
		mothershipRb.MovePosition (transform.position - new Vector3 (0, verticalStep, 0));

	}
	void OnTriggerEnter(Collider objetTouche)
	{
		if (objetTouche.tag == "MUR")
		{
			if (transform.position.x > 0)
			{
				sens = -1f;
				Descendre ();
					
		    }
			else if (transform.position.x < 0 && sens != 1f)
			{
			sens = 1f;
			Descendre ();

			if (objetTouche.tag == "MurDefaited") 
				{
					GameOver ();
				}

		}
		
	}
}
	void GameOver(){

	}

	void Victory(){

	}
	public GameObject missileEnemie;

	void Tirer(){
		
		Transform coloneChoisie = transform.GetChild(Random.Range (0, transform.childCount - 1));
		if (coloneChoisie.childCount < 1) 
		{
			Destroy (coloneChoisie.gameObject);
			Tirer ();
			return;
		}


		Transform dernierAlienDeLaColonne= coloneChoisie.GetChild(coloneChoisie.childCount - 1);

		Instantiate (missileEnemie, dernierAlienDeLaColonne.position, transform.rotation);

		Invoke("Tirer", 1f + Random.value); 

	}
}
