using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCardboard : MonoBehaviour
{
    public GameObject Player; //defines a player in the inspector to follow
    public float Dis;  //a float to track the distance of the dog and player
    public Transform target;
    public Animator animator; //gathers an animator

    // Start is called before the first frame update
    void Start()
    {

        animator = gameObject.GetComponent<Animator>(); /*at the start of the scene it gets the Animator
                                                        * of the object and sets it to the animator 
                                                        * variable */

    }

    // Update is called once per frame
    void Update()
    {
        Dis = Vector3.Distance(transform.position, Player.transform.position);
        //defines the distance between the dog and the player

        if (Dis >= 5)  /*if the distance is greater or equal to 5, the dog moves towards the player while playing the dog 
                        * walk animation */
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 5 * Time.deltaTime);
            if (target != null)    //if there is a target, the dog turns to look at them
            {
                transform.LookAt(target);

            }


        }



    }
}
