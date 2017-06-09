using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testContol : MonoBehaviour {

	//public float moveSpeed ;
	public float jumpForce ;
	public KeyCode moveUp;
	public float gravity_mutipal ;

	private Rigidbody rb;


	public void FixedUpdate() {
		GetComponent<Rigidbody>().AddForce(Physics.gravity*gravity_mutipal, ForceMode.Acceleration);
	}



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
