using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get horizontal input value (-1 for left, 1 for right)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the velocity vector
        Vector2 velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        // Update the velocity of the rigidbody
        rb.velocity = velocity;
    }
}
