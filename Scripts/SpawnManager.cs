using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject speedPowerup;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private float spawnRangeX = 10;
    private float spawnPosZ = 10;
    private float Timer = 3f;
    private int powerupDecider = 6;
    void Update()
    {
        Timer -= 0.01f;
        if (Timer <= 0f)
        {
            powerupDecider = Random.Range(0, 5);
            Timer = 3f;
        }

        if (powerupDecider == 1)
        {
            SpawnPowerup();
            powerupDecider = 6;
        }




    }

    void SpawnPowerup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));
        Instantiate(speedPowerup, spawnPos, transform.rotation);

    }
}