using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoveController : MonoBehaviour
{
    [Header("Movement")]
    public float xForce;
    public float yForce;

    private Rigidbody2D rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        PushBall();

    }
    void PushBall()
    {
        float randomDirection = Random.Range(0, 2);
        if (randomDirection < 1.0f)
        {
            rb.AddForce(new Vector2(xForce, yForce));
        }
        else
        {
            rb.AddForce(new Vector2(-xForce, yForce));
        }
    }
    
}
