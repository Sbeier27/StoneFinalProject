using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public GameObject balloon; //defines the balloon object
    public float speed = 2f; //defines the speed they move at
    public float height; //defines the height to move
    public float startY; //defines the starting height

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position; //defines the position the object is at
        var newY = startY + height * Mathf.Sin(Time.time * speed); /*creates a new Y to get to from the height to move, the starting
                                                                    * height and the height to move, at the speed defined*/
        
        transform.position = new Vector3(pos.x, newY, pos.z);//moves the object to the new Y created earlier
    }
}
