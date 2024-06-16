using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] Canvas UI;
    [SerializeField] GameObject player;
    [SerializeField] GameObject Camera;
    [SerializeField] TMP_Text timer;

    [SerializeField] AudioSource reload;
    [SerializeField] AudioSource changeGun;

    public PlayerProfile playerData;
    public Guns currentWeapon;

    public bool grounded;

    public int XP;

    public float playerHealth = 100;
    private int playerHealthMax;
    private int playerHealthMin;

    public int angleFlag = 0;
    public float time = 60;
    float seconds;
    

    // Start is called before the first frame update
    void Start()
    {
        currentWeapon = playerData.weapons[0];
    }

    public void timeCounter()
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

        XP = playerData.XP;
    }

    private void FixedUpdate()
    {
        time -= Time.deltaTime;
        if (time >=60)
            seconds = time - 60f*(int)(time/60f);
        if (seconds >= 10)
            timer.text = "0" + ((int)(time / 60)).ToString() + ":" + ((int)seconds).ToString();
        else
            timer.text = "0" + ((int)(time / 60)).ToString() + ":" + "0" + ((int)seconds).ToString();

    }
}