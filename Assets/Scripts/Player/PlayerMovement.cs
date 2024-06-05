using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement set and restrictions
    [SerializeField] float moveSpeed;
    [SerializeField] float moveFactor;
    [SerializeField] float jump;

    // Player Object
    Rigidbody rb;
    Transform transform;
    Vector3 playerVelocity = Vector3.zero;
    Vector3 movementDirection = Vector3.zero;

    // Key Inputs
    float hor;
    float vert;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();

        rb.freezeRotation = true;
    }

    private void move()
    {
        movementDirection = (transform.forward * vert) + (transform.right * hor);

        rb.AddForce (movementDirection * moveSpeed * moveFactor, ForceMode.Force);
    }

    private void FixedUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        if ((hor != 0) || (vert != 0))
            move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
