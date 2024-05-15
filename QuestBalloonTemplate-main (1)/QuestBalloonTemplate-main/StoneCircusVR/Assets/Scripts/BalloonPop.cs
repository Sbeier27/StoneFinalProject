using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPop : MonoBehaviour
{
    private ScoreManager scoreManager; //defines what is managing the score
    public GameObject Balloon; //defines the game object
    public int pointValue;//defines the amount of points the object is worth
    public AudioClip clip;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>(); //gets the Canvas that the scoreManager script is attached to

    }

    void OnCollisionEnter(Collision collision)  /*on collision with the Dart object it destroys the balloon and then adds the 
                                                 * point value to the score*/
    {
        if (collision.gameObject.tag.Equals("Dart") == true)
        {
            Destroy(Balloon);
            source.PlayOneShot(clip);
            scoreManager.UpdateScore(pointValue);
        }
    }

}
