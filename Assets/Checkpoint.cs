using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Player"))
        {
            // Set the player's respawn point to this checkpoint
            GameManager.Instance.SetRespawnPoint(transform.position);
            Debug.Log("Checkpoint reached!");
        }
    }
}
