using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartThrow : OVRGrabbable
{
    public Rigidbody rb; //gets a rigidboy
    public GameObject dart; //gets the dart object
    public GameObject spot;

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity) /*Overrides the GrabEnd function so when you let go of the
                                                                                   * object it sends it forward, before creating another instance
                                                                                   * of the object to be picked up*/
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        // Access the Rigidbody component of the grabbed object correctly
        rb = gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(Vector3.up * 2f, ForceMode.VelocityChange);
            Instantiate(dart, spot.transform.position, spot.transform.rotation);
        }
    }
}
