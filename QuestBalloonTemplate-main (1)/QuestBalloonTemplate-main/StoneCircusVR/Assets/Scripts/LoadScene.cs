using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class LoadScene : MonoBehaviour
{
    public int level;
    
    
    void OnTriggerEnter(Collider ChangeScene) // can be Collider HardDick if you want.. I'm not judging you
    {
        if (ChangeScene.gameObject.CompareTag("OVRPlayerController"))
        {
            UnityEngine.Application.LoadLevelAdditive(level); //1 is the build order it could be 1065 for you if you have that many scenes
        }
    }
}
