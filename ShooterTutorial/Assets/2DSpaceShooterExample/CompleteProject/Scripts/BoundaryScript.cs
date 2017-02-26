using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour {

	public GameObject SharedScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.tag == "Enemy") {
			SharedScript.GetComponent<SharedScript> ().DecreaseLives ();
		}

	}
}
