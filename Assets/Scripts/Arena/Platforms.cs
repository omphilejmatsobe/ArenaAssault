using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    [SerializeField] GameObject platform;

    int rotate = 0;
    bool setCapture = false;
    Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            setCapture = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            setCapture = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && setCapture == true)
        {
            rotate++;
            angleFix();
        }
        else if (Input.GetKeyDown(KeyCode.E) && setCapture == true)
        {
            rotate--;
            angleFix();
        }
    }

    private void angleFix()
    {
        if (rotate > 3)
            rotate = 0;
        else if (rotate < 0)
        {
            rotate = 3;
        }

        Debug.Log("Rotate = " + rotate);
    }

    private void FixedUpdate()
    {
        rotation = Quaternion.Euler(0, 90 * rotate, 0);
        platform.transform.rotation = Quaternion.Slerp(platform.transform.rotation, rotation, Time.deltaTime * 5f);
    }
}
