using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genBuliding : MonoBehaviour {

	public GameObject thePlatform;
	public Transform genPoint;
	public float distanceBetaween;

	private bool genYet = false;


	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position.x < 3.64f  && genYet == false) {
			
			Instantiate (thePlatform, new Vector3 (4f , .0f , .0f), new Quaternion(0,0,0,0));
			genYet = true;
			Debug.Log ("new");
			Destroy (this);

		}

	}
}
