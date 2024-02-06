using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Assuming you have a GameManager script for managing respawns
            GameManager.Instance.RespawnPlayer();
        }
    }
}
