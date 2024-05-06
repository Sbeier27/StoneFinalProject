using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPop : MonoBehaviour
{
    private ScoreManager scoreManager; //defines what is managing the score
    public GameObject Balloon; //defines the game object
    public int pointValue;//defines the amount of points the object is worth

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>(); //gets the Canvas that the scoreManager script is attached to

    }

    public void OnCollisionEnter(Collision collision) /*on collision with the Dart object it destroys the balloon and then adds the 
                                                       * point value to the score*/
    {
        if (collision.gameObject.name == "Dart") 
        {
            Destroy(Balloon);
            scoreManager.UpdateScore(pointValue);

        }


    }
  
}
