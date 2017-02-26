using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharedScript : MonoBehaviour {

//	public GUIText ScoreText;
	public GUIText LivesUIText;
	public GameObject GameManager;

	public int lives = 3;

	// Use this for initialization
	void Start () {
		LivesUIText.text = "Lives left: " + lives.ToString ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DecreaseLives() {
		lives--;
		LivesUIText.text = "Lives left: " + lives.ToString ();

		if (lives == 0) {
			GameManager.GetComponent<GameControllerScript> ().SetGameManagerState (GameControllerScript.GameManagerState.Gameover);
		}
	}

}
