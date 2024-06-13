using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUIPlayerData : MonoBehaviour
{

    [SerializeField] PlayerProfile player;
    [SerializeField] TMP_Text CashText;
    [SerializeField] TMP_Text UXText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CashText.text = "$" + player.Cash.ToString();
        UXText.text = player.XP.ToString() + "XP";
    }
}
