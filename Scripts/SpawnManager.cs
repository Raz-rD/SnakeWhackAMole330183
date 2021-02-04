using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Collectible;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(methodName: "SpawnCollectible", time: startDelay, repeatRate: spawnInterval);
    }

    // Update is called once per frame
    private float spawnRangeX = 10;
    private float spawnPosZ = 10;
    private float spawnTimer = 120;
    void Update()
    {

       




    }

    void SpawnCollectible()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));
 

    }
}