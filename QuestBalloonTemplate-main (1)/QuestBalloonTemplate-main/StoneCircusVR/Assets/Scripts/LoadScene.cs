using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class LoadScene : MonoBehaviour
{
    public int level; //gets the level number
    
    
    void OnTriggerEnter(Collider ChangeScene) /*on triggering the event by colliding with the player object it loads the assigned scene
                                               * taking the player there*/
    {
        if (ChangeScene.gameObject.CompareTag("OVRPlayerController"))
        {
            UnityEngine.Application.LoadLevelAdditive(level); //1 is the build order it could be 1065 for you if you have that many scenes
        }
    }
}
