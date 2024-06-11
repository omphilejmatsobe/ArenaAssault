using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Canvas UI;
    [SerializeField] GameObject player;
    [SerializeField] GameObject Camera;

    private int playerHealth;
    private int playerHealthMax;
    private int playerHealthMin;

    public int angleFlag = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
            angleFlag--;
        if (Input.GetKeyDown(KeyCode.LeftControl))
            angleFlag++;

        if (angleFlag < 0)
            angleFlag = 3;

        if (angleFlag > 3)
            angleFlag = 0;
    }

    private void FixedUpdate()
    {

    }
}