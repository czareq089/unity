using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;
    private float inputX;
    public float limit = 16f;
    public float sprint_speed = 12f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(inputX * speed, 0));

        if (inputX == 0)
        {
            rb.angularVelocity = 0;
        }

        if (rb.velocity.magnitude > limit)
        {
            rb.angularVelocity = limit;
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(new Vector2(inputX * sprint_speed, 0));
        }
    }
}

