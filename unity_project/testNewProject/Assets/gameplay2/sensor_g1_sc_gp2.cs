using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor_g1_sc_gp2 : MonoBehaviour {
	private Rigidbody rb;
	private float target_y_movespeed = 0;

	public float target = 0;



	private Rigidbody rb2;




	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		target = random_prosition() ;
		rb2 =  GameObject.Find("aaa").GetComponent<Rigidbody>();

	}

	float random_prosition(){
		return Mathf.Round(Random.Range (-5, 5) * 100f) / 100f; 
	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "middle") {
			target = random_prosition();	
			rb2.AddForce(new Vector3 (0,1000 ,0));
		}
	}

	
	// Update is called once per frame
	void Update () {

		if (rb.position.y > target) {
			target_y_movespeed = -1f;
		} else if(rb.position.y < target){
			target_y_movespeed = 1f;
		}else{
			target_y_movespeed = 0f;
		}

		rb.MovePosition ( new Vector3 (rb.position.x, rb.position.y, rb.position.z)+
			new Vector3 (0, target_y_movespeed, 0)// *Time.deltaTime
		);
	}
}
