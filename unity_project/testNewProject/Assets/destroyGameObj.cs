﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGameObj : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject,1f);
	}
	// Update is called once per frame
	void Update () {


	}

}
