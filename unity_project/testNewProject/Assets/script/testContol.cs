using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testContol : MonoBehaviour {

	//public float moveSpeed ;
	public float jumpForce ;
	public KeyCode moveUp;
	public KeyCode Restart;
	public float gravity_mutipal ;
	public LayerMask whatIsLayerCanJump;

	private bool onGround;
	private int jumpStep;

	private Rigidbody rb;




	void Start () {
		rb = GetComponent<Rigidbody> ();

		Time.timeScale = 1f ; // speed up


	}


	public void FixedUpdate() {
		GetComponent<Rigidbody>().AddForce(Physics.gravity*gravity_mutipal, ForceMode.Acceleration);
	}


	public void  OnCollisionStay(Collision collision )
	{
		

		if (collision.collider.gameObject.layer == 8) {
			jumpStep = 2;
		}

	}

	bool isCharCanJump(){
		bool boolIsCharCanJump = false;
		if (jumpStep > 1) {
			boolIsCharCanJump = true;
		}

		return (boolIsCharCanJump);
	}


	// Use this for initialization


	public void getAttack(){
		rb.AddForce (Vector3.left * 10);
	}


	// Update is called once per frame
	void Update () {
		//gojump = Physics.
		if (Input.GetKeyDown (moveUp) && isCharCanJump()==true ) {
			rb.velocity = new Vector3 (rb.velocity.x, jumpForce ,rb.velocity.z);
			jumpStep--;
		}
		if (Input.GetKeyDown (Restart)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	
	}



}
