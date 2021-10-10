using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoveController : MonoBehaviour
{
    [Header("Movement")]
    public float speedBall;

    private Rigidbody2D rb;
    private Vector2 velocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        velocity = new Vector2(speedBall, 0);

    }

    private void FixedUpdate()
    {


        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

    }
}
