using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle_g2_sc_gp2 : MonoBehaviour {
	
	private Rigidbody rb;
	private float target_y_movespeed = 0;

	public float target = 0;







	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();


	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "sensor") {

			//rb.drag = 0;
		}

	}
	void OnTriggerStay (Collider other){
		if (other.gameObject.name == "bottom") {
			//rb.drag = 10;
		}
	}

	// Update is called once per frame
	void Update () {


	

	
		
	}
}
