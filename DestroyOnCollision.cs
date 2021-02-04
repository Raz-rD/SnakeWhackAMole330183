using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
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
        }


    }
}
