﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reset_scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerStay (Collider other) {
		if (other.gameObject.name == "hero") {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
	// Update is called once per frame
	void Update () {
			
	}
}
