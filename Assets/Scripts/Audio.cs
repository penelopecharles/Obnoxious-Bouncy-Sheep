using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter (Collision collision) {
		foreach (ContactPoint contact in collision.contacts) {
			Debug.DrawRay (contact.point, contact.normal, Color.white);
		}
		if (collision.gameObject.name == "PlayerController") {
			audio.Play (); 
		}

}}
