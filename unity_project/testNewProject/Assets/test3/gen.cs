using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gen : MonoBehaviour {

	public GameObject thePlatform;
	public GameObject theSenser;
	public Transform childObj;

	public float distanceBetaween;

	private bool genYet = false;

	// Use this for initialization
	void Start () {
		//transform.position.x = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < 0f  && genYet == false) {
			childObj = thePlatform.gameObject.transform.GetChild(Random.Range(0,3));
			Instantiate (childObj, new Vector3 (1f , .0f , .0f), new Quaternion(0,0,0,0));

			childObj = thePlatform.gameObject.transform.GetChild(Random.Range(0,3));
			Instantiate (childObj, new Vector3 (2f , .0f , .0f), new Quaternion(0,0,0,0));

			childObj = thePlatform.gameObject.transform.GetChild(Random.Range(0,3));
			Instantiate (childObj, new Vector3 (3f , .0f , .0f), new Quaternion(0,0,0,0));

			Instantiate (theSenser, new Vector3 (3f , .0f , .0f), new Quaternion(0,0,0,0));
			genYet = true;

			Destroy (this);

		}
	}
}
