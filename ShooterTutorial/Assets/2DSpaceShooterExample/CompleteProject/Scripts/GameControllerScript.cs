using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public GameObject hazard;


    // Text that will be changed (make a text object)
    public GUIText scoreText;
    // Actual score variable (will be called in collisionController)
    private int score;

    void Start ()
    {
        score = 0;
        UpdateScore ();
    }


    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore ();
    }

    void UpdateScore ()
    {
        scoreText.text = "Score: " + score;
    }
}
