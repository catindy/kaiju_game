using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotDamage : MonoBehaviour {

	public KeyCode attack;

	private Rigidbody rb;

	public bool beingattack = false;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	//void OnCollisionEnter( Collision collision){

//		collision.collider.attachedRigidbody.AddForce(new Vector3 ( -50 , 50, 0));

//	}
	void OnTriggerStay (Collider other) {
		if (other.gameObject.name == "character") {



			if (beingattack==true) {
				
				Destroy(rb.gameObject,.5f);
			}
			else{
				other.attachedRigidbody.AddForce (new Vector3 (-5, 30, 0));
			}



		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (attack)) {
			StartCoroutine (TestCoroutine ());

		}

	}
				IEnumerator TestCoroutine(){
					beingattack = true;
					yield return new WaitForSeconds(1);
					beingattack = false;
				}
}
