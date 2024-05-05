using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonFloat : OVRGrabbable
{
    public Rigidbody rb;
    public AudioSource source; //defines an audio source in the inspector
    public AudioClip clip;//defines an audio clip in the inspector
    public GameObject balloon;
    public GameObject spot;
    // Start is called before the first frame update
    /*void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }*/

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        // Access the Rigidbody component of the grabbed object correctly
        rb = gameObject.GetComponent<Rigidbody>();
        source.PlayOneShot(clip);
        if (rb != null)
        {
            rb.useGravity = false;
            rb.AddForce(Vector3.up * 1f, ForceMode.VelocityChange);
        }
        Instantiate(balloon, spot.transform);
        
    }
}
