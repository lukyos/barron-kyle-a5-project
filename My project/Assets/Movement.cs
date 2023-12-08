using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Player1");
        }
        else
        {
            movement = Input.GetAxisRaw("Player2");

        }
        rb.velocity = new Vector2(rb.velocity.x, speed * movement); 
    }
}
