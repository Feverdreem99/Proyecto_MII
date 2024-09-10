using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; // Speed of the player
    public float jumpForce = 5f; // Force applied for jumping

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    void Move()
    {
        // Get input from horizontal and vertical axes
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(moveX, 0, moveZ) * moveSpeed;

        // Apply movement to the Rigidbody
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
