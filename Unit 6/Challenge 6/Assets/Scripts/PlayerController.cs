using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get horizontal and vertical input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized;

        // Move the player
        rb.velocity = movement * moveSpeed;
    }

}
