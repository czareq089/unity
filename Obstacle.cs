using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 2f;
    public float speedneg = -2f;
    Rigidbody2D rb;
    private float limit = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(limit == 0 || limit % 2 != 0)
        { 
            rb.AddForce(new Vector2(0, speed));
            limit++;
        }
        if(limit % 2 == 0)
        {
            rb.AddForce(new Vector2(0, speedneg));
        }

        Debug.Log(limit);
    }
}
