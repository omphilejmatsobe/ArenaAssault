using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float camHeight;
    [SerializeField] float camDis;
    [SerializeField] private float camSpeed;
    [SerializeField] Transform targetTransform;
    [SerializeField] GameManager gameManager;
    Vector3 targetPos = Vector3.zero;

    GameObject child;

    float angle = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        angle = 90f * (int)gameManager.angleFlag;
        Quaternion rotate = Quaternion.Euler(0, angle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime * 5f);
    }

    private void FixedUpdate()
    {
        targetPos = targetTransform.position;

        targetPos.y += camHeight;
        targetPos.z -= camDis;

        transform.position = Vector3.Lerp(transform.position, targetPos, camSpeed * Time.deltaTime);
    }
}
