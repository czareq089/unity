using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score = 0;
    public CapsuleCollider2D cpc;
    // Start is called before the first frame update


    private void OnCollisionEnter2D(Collision2D collision)
    {

        score++;
        Destroy(gameObject);
        Debug.Log(score);
        
    }
}


