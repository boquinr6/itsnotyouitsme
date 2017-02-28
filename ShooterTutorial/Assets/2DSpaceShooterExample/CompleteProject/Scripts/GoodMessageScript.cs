﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodMessageScript : MonoBehaviour {

	public GameObject Explosion;
	GameObject SharedScript;
	float speed;

	public void Init() {
		//		lives = MaxLives;
		//		LivesUIText.text = lives.ToString ();
		gameObject.SetActive(true);
	}

	// Use this for initialization
	void Start () {

		speed = Random.Range(1f, 5f);
		SharedScript = GameObject.Find("SharedValues");

	}

	// Update is called once per frame
	void Update () {

		Vector2 position = transform.position;

		position = new Vector2 (position.x + speed * Time.deltaTime, position.y);

		transform.position = position;

		//		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));

		//		if (transform.position.x > max.x) {
		//			SharedScript.GetComponent<SharedScript> ().DecreaseLives ();
		//			Destroy (gameObject);
		//		}

	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.tag == "PlayerLaser" || col.tag == "Player") {
			PlayExplosion ();
			SharedScript.GetComponent<SharedScript> ().DecreaseLives ();
			Destroy (gameObject);
		}

		if (col.tag == "Boundary") {
			Destroy (gameObject);
		}

	}

	void PlayExplosion() {
		GameObject explosion = (GameObject)Instantiate (Explosion);
		explosion.transform.position = transform.position;
	}
}
