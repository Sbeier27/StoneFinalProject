using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPop : MonoBehaviour
{
    private ScoreManager scoreManager;
    public GameObject Balloon;
    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    public void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.name == "Dart") 
        {
            Destroy(Balloon);
            scoreManager.UpdateScore(pointValue);

        }


    }
  
}
