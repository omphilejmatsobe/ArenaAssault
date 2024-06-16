using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MovingPlatForm : MonoBehaviour
{
    [SerializeField] float step = 0.01f;
    [SerializeField] Transform targetOne;
    [SerializeField] Transform targetTwo;

    bool allow = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (allow == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetTwo.position, step);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetOne.position, step);
        }
        
        if (transform.position == targetOne.position)
        {
            allow = false;
        }
        
        if (transform.position == targetTwo.position)
        {
            allow = true;
        }
    }
}
