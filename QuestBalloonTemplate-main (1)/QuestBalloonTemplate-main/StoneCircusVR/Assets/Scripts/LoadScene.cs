using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string level; //gets the level name
    
    
    void OnCollisionEnter(Collision collision) /*on triggering the event by colliding with the player object it loads the assigned scene
                                               * taking the player there*/
    {
        if (collision.gameObject.tag.Equals("PlayerController") == true)
        {
            SceneManager.LoadScene(level); 
        }
    }
}
