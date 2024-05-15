using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUp : MonoBehaviour
{
    public GameObject mime;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)  /*on collision with the Dart object it destroys the balloon and then adds the 
                                                 * point value to the score*/
    {
        if (collision.gameObject.tag.Equals("Dart") == true)
        {
            mime.transform.localScale = new Vector3(10f, 10f, 10f);



        }
    }
}
