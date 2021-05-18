using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    Vector3 spawnPosition = new Vector3(25, 0, 0);
    public float startDelay = 2f;
    public float repeatRate = 2f;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("ObstacleSpawn", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ObstacleSpawn()
    {
        if(playerController.isGameOver == false) Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);

    }
}
