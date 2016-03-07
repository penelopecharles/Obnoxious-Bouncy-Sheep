using UnityEngine;
using System.Collections;

public class scriptEstragon : MonoBehaviour {

	private ParticleSystem hitParticles;

	void Awake ()	
	{
		hitParticles = GetComponentInChildren<ParticleSystem>();
	}

	void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.name == "PlayerController") {
			hitParticles.Play ();
		}

	}
}