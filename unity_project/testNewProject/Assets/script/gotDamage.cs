﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotDamage : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	//void OnCollisionEnter( Collision collision){

//		collision.collider.attachedRigidbody.AddForce(new Vector3 ( -50 , 50, 0));

//	}
	void OnTriggerStay (Collider other) {
		if (other.gameObject.name == "character") {
			other.attachedRigidbody.AddForce (new Vector3 (-20, 50, 0));
		}

	}

	// Update is called once per frame
	void Update () {


	}
}