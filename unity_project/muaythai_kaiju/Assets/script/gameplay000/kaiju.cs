using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kaiju : MonoBehaviour {




	void Explode() {
		var exp = GetComponent<ParticleSystem>();
		exp.Play();

	}

	void Start() {

	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "hero") {
			//Destroy (other.gameObject, 1f);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		} else {
			Destroy(other.gameObject,1f);
			Explode();
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
