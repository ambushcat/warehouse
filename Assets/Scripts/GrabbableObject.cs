using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    private Rigidbody rb;
    private Transform grabPoint;
    private float lerpSpeed = 10f;
    private bool isGrabbed = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Grab(Transform grabPoint)
    {
        this.grabPoint = grabPoint;
        rb.useGravity = false;
        isGrabbed = true;
    }

    public void Drop()
    {
        grabPoint = null;
        rb.useGravity = true;
        isGrabbed = false;
    }

    private void FixedUpdate()
    {
        if(grabPoint != null)
        {
            Vector3 newPos = Vector3.Lerp(transform.position, grabPoint.position, Time.deltaTime * lerpSpeed);
            rb.MovePosition(newPos);
        }
    }

    public bool isBeingGrabbed()
    {
        return isGrabbed;
    }
}
