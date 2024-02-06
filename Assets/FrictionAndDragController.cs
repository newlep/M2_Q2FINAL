using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionAndDragController : MonoBehaviour
{
    public float friction = 0.5f;
    public float drag = 0.1f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        ApplyFriction();
        ApplyDrag();
    }

    private void ApplyFriction()
    {
        Vector3 frictionForce = -rb.velocity.normalized * friction;
        rb.AddForce(frictionForce);
    }

    private void ApplyDrag()
    {
        Vector3 dragForce = -rb.velocity * drag;
        rb.AddForce(dragForce);
    }
}
