using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonFloat : OVRGrabbable
{
    public Rigidbody rb; //defines the rigidbody
    public AudioSource source; //defines an audio source in the inspector
    public AudioClip clip;//defines an audio clip in the inspector
    public AudioClip clip2;
    public GameObject balloon; //defines in the inspector a balloon object
    public GameObject spot; //defines a location in the inspector
    // Start is called before the first frame update
    /*void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }*/

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)  /*extending the OVRGrabbable class this overrides
                                                                                    * the grab end function and makes whatever's released
                                                                                    * float up into the sky before creating a copy in the 
                                                                                    * original's spot, while playing an audio clip*/
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        // Access the Rigidbody component of the grabbed object correctly
        rb = gameObject.GetComponent<Rigidbody>();
        source.PlayOneShot(clip);
        source.PlayOneShot(clip2);
        if (rb != null)
        {
            rb.useGravity = false;
            rb.AddForce(Vector3.up * 1f, ForceMode.VelocityChange);
        }
        Instantiate(balloon, spot.transform.position, spot.transform.rotation);


    }
}
