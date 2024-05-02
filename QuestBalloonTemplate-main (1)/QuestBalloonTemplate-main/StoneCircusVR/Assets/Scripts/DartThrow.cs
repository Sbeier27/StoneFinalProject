using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartThrow : OVRGrabbable
{
    public Rigidbody rb;
    public GameObject dart;

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        // Access the Rigidbody component of the grabbed object correctly
        rb = gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(Vector3.up * 2f, ForceMode.VelocityChange);
            Instantiate(dart);
        }
    }
}
