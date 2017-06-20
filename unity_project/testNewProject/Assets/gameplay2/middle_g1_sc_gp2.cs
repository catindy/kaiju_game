using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle_g1_sc_gp2 : MonoBehaviour {
	public float jumpForce = 1;
	public KeyCode moveUp;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (moveUp)  ) {
			rb.AddForce(new Vector3 (0, 200 ,0));
		}
	}
}
