using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollectible : MonoBehaviour
{
    public GameObject Player;
    public GameObject Collectible;
    // Start is called before the first frame update

    private float spawnRangeX = 10;
    private float spawnPosZ = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        //detects collision, adds 1 score and runs spawning script
        if (collision.gameObject.name == "player")
        {
            Destroy(gameObject);
            ScoreScript.scoreValue += 1;
            SpawnCollectible();
            
        }

       
    }

    // the script to spawn a new collectible
    void SpawnCollectible()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));
        Instantiate(Collectible, spawnPos, transform.rotation);

    }
}
