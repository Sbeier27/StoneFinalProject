using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class LoadScene : MonoBehaviour
{
    public string scene;


    // Start is called before the first frame update
    public void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.name == "OVRCameraRig") 
        {

            UnityEngine.Application.LoadLevel(scene);


        }


    }
}
