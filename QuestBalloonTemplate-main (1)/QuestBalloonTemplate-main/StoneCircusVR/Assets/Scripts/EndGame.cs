using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class EndGame : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) /*on triggering the event by colliding with the player object it ends the game*/
    {
        if (collision.gameObject.tag.Equals("Player") == true)
        {
            UnityEngine.Application.Quit();
        }
    }
}
