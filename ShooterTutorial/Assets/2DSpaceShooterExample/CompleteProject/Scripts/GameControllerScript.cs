using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
//    public GameObject hazard;

	public GameObject playerShip;
	public GameObject playButton;
	public GameObject enemySpawner;
	public GameObject enemyShip;

	public enum GameManagerState {
		Opening,
		Gameplay,
		Gameover,
	}

	GameManagerState GMState;

//    // Text that will be changed (make a text object)
//    public GUIText scoreText;
//    // Actual score variable (will be called in collisionController)
//    private int score;

    void Start ()
    {
		GMState = GameManagerState.Opening;
//        score = 0;
//        UpdateScore ();
    }

	void UpdateGameManagerState() {
		switch (GMState) {
		case GameManagerState.Opening:
			playButton.SetActive (true);
			playerShip.SetActive (false);
			break;
		case GameManagerState.Gameplay:
			playButton.SetActive (false);
			enemyShip.SetActive (true);
			playerShip.SetActive (true);
//				playerShip.GetComponent<EnemyControl> ().Init ();
			enemySpawner.GetComponent<spawnScript> ().ScheduleEnemySpawner();
			break;
		case GameManagerState.Gameover:
			enemySpawner.GetComponent<spawnScript> ().UnscheduleEnemySpawner ();
			enemyShip.SetActive (false);
			//Stops game
			Time.timeScale = 0;
			//quits app
//			Application.Quit();
			Invoke ("ChangeToOpeningState", 1f);
			break;
		}
	}

	public void SetGameManagerState(GameManagerState state) {
		GMState = state;
		UpdateGameManagerState ();
	}

	public void StartGamePlay() {
		GMState = GameManagerState.Gameplay;
		UpdateGameManagerState ();
	}

	public void ChangeToOpeningState() {
		GMState = GameManagerState.Opening;
		UpdateGameManagerState ();
	}


//    public void AddScore (int newScoreValue)
//    {
//        score += newScoreValue;
//        UpdateScore ();
//    }
//
//    void UpdateScore ()
//    {
//        scoreText.text = "Score: " + score;
//    }
}
