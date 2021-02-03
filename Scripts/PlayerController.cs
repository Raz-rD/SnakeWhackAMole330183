using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody rb;
    private float sideBound = 10;
    private float topBound = 9;

    // Start is called before the first frame update
    void Start()
    {  
        //K
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement Code
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * Speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -Speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -Speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * Speed);
        }

        //Stop movement when near the edges of the screen
        if (transform.position.z > topBound)
        {
            rb.velocity = new Vector3(0, 0, -1);
        }
        if (transform.position.z < -topBound)
        {
            rb.velocity = new Vector3(0, 0, 1);
        }
        if (transform.position.x > sideBound)
        {
            rb.velocity = new Vector3(-1, 0, 0);
        }
        if (transform.position.x < -sideBound)
        {
            rb.velocity = new Vector3(1, 0, 0);
        }
    }
}
