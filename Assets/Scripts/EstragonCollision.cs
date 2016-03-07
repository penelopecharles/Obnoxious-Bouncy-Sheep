using UnityEngine;
using System.Collections;

public class EstragonCollision : MonoBehaviour {


	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Estragon") 
		{
			Destroy (col.gameObject);
		}
	}

}
