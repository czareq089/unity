using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);


    void Start()
    {

    }

    void Update()
    {

        var inputX = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(speed.x * inputX / 8, speed.y * 0);
        movement *= Time.deltaTime;

        transform.Translate(movement);
    }
}

