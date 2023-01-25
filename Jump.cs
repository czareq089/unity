using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float height = 9f;
    private bool isJumping = false;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && (isJumping == false))
        {
            rb.AddForce(new Vector2(0f, height), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isJumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isJumping = true;
        }
    }
}

