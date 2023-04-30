using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2(0, speed);
            transform.position = Vector3.left;
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0);
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -speed);
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0);
            transform.position = Vector3.right;
            
        }
    }
}
