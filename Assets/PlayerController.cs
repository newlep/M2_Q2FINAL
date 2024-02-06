using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 700f;
    public float jumpForce = 10f;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.5f, groundLayer);

        // Handle player input
        HandleMovementInput();

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
            Jump();
        }

        Debug.Log(isGrounded);
    }

    private void HandleMovementInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Apply movement to the rigidbody
        rb.AddForce(moveDirection * moveSpeed);

        // Rotate the player based on input
        if (moveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    private void Jump()
    {
        Debug.Log("Jumping!");
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
