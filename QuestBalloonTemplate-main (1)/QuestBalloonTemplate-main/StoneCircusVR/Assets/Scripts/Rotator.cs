using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]private Vector3 rotator; //allows you to adjust the rotation in the inspector and define it
    
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotator * Time.deltaTime);//takes the attached object and rotates it multiplied by the time to give it speed
    }
}
