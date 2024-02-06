using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSurface : MonoBehaviour
{
    public float frictionMultiplier = 1.0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FrictionAndDragController controller = collision.gameObject.GetComponent<FrictionAndDragController>();
            if (controller != null)
            {
                controller.friction *= frictionMultiplier;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FrictionAndDragController controller = collision.gameObject.GetComponent<FrictionAndDragController>();
            if (controller != null)
            {
                controller.friction /= frictionMultiplier;
            }
        }
    }
}
