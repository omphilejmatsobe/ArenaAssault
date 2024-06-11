using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // GameManager
    [SerializeField] GameManager gameManager;

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
    float moveSelectorX;
    float moveSelectorY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();

        rb.freezeRotation = true;
    }

    private void move()
    {
        if (gameManager.angleFlag == 0)
        {
            moveSelectorX = hor;
            moveSelectorY = vert;
        }
        else if (gameManager.angleFlag == 1)
        {
            moveSelectorX = vert;
            moveSelectorY = (-1) * hor;
        }
        else if (gameManager.angleFlag == 2)
        {
            moveSelectorX = (-1) * hor;
            moveSelectorY = (-1) * vert;
        }
        else
        {
            moveSelectorX = (-1) * vert;
            moveSelectorY = hor;
        }

        movementDirection = (transform.forward * moveSelectorY) + (transform.right * moveSelectorX);

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
