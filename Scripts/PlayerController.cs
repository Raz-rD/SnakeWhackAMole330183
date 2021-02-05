using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody rb;
    public GameObject speedPowerup;
    private float speedTimer = 0f;
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
            rb.AddForce(transform.forward * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -Speed * Time.deltaTime) ;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * Speed * Time.deltaTime);
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
        //counts down the speedtimer
        speedTimer -= 0.01f;

        if (speedTimer < 0f)
        {
            Speed = 300f;
        }
        else if (speedTimer > 0f)
        {
            Speed = 600f;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        //detects collision with Speed powerup, adds speed for 5 seconds
        if (collision.gameObject.name == "SpeedPowerup")
        {
            speedTimer = 5f;
        }

    }
}
