using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Vector3 respawnPoint;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetRespawnPoint(Vector3 point)
    {
        respawnPoint = new Vector3(point.x,point.y+3,point.z);
        Debug.Log(respawnPoint);
    }

    public void RespawnPlayer()
    {
        
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = respawnPoint;
    }
}
