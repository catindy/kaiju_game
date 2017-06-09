using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testContol : MonoBehaviour {

	public float moveSpeed ;
	public float jumpForce ;
	public KeyCode moveUp;


	private Rigidbody rb;




	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (moveUp)) {
			rb.velocity = new Vector3 (rb.velocity.x, jumpForce ,rb.velocity.z);
		}
		
	}
}
