using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score; //defines the current score
    public UnityEngine.UI.Text scoreText; //the text object used to display the score
    
    void Start()
    {
        StartCoroutine(SpawnTarget()); //on start it holds the update until it's supposed to be updated
        score = 0; //sets the score to 0
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            UpdateScore(5); //when it's time it calls the update score function to add 5 points
        }
    }
    public void UpdateScore(int scoreToAdd) /*taking in and int of the score to add it then adds it to the current score
                                             * and then updates the text ui to display the score */
    {
        score += scoreToAdd;
        scoreText.text = "Balloon Pop score: " + score;
    }
}
