using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_obj : MonoBehaviour {

	public float moveSpeed = -1;
	public KeyCode startKey = KeyCode.Return;

	private Rigidbody rb;

	private int checkStart = 0 ;

	public bool moveStatus = true;






	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();


	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (startKey) || moveStatus == true) {
			checkStart = 1;
		}
		if (checkStart == 1) {
			rb.MovePosition ( new Vector3 (rb.position.x, rb.position.y, rb.position.z)+
				new Vector3 (moveSpeed, 0, 0) *
				Time.deltaTime);
		}

	}
		


}