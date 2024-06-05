using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float camHeight;
    [SerializeField] float camDis;
    [SerializeField] private float camSpeed;
    [SerializeField] Transform targetTransform;
    Vector3 targetPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        targetPos = targetTransform.position;

        targetPos.y += camHeight;
        targetPos.z -= camDis;

        transform.position = Vector3.Lerp(transform.position, targetPos, camSpeed * Time.deltaTime);
    }
}
