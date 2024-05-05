using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public UnityEngine.UI.Text scoreText;
    
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            UpdateScore(5);
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Balloon Pop score: " + score;
    }
}
