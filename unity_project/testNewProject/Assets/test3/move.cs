﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public float moveSpeed = -1;
	public float jumpForce ;
	public KeyCode startKey;

	private Rigidbody rb2;
	private int checkStart = 0 ;

	public bool moveStatus = true;
		
	// Use this for initialization
	void Start () {
		rb2 = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb2.MovePosition ( new Vector3 (rb2.position.x, rb2.position.y, rb2.position.z)+
			new Vector3 (moveSpeed, 0, 0) *
			Time.deltaTime);
		
	}
}
