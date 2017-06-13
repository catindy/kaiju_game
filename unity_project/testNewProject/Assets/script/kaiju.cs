using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kaiju : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "character") {
			//Destroy (other.gameObject, 1f);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
