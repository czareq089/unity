using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Obstacle : MonoBehaviour
{
    public Vector2 distance = new Vector2(0, 3);
    public Vector2 negdist = new Vector2(0, -6);
    private float limit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        limit++;
        if (limit == 1 || limit == 2 || limit == 3)
        {
            transform.position = Vector2.Lerp(transform.position, distance, Time.deltaTime);
        }
        else if (limit == 4 || limit == 5 || limit == 6)
        {
            transform.position = Vector2.Lerp(transform.position, negdist, Time.deltaTime);
        }
        Debug.Log(limit);
    }
}
