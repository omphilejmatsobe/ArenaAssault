using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<Guns> AllGuns;
    [SerializeField] PlayerProfile playerData;
    [SerializeField] TMP_Text text;


    [Header("Shop")]
    [SerializeField] List<TMP_Text> buttonName;
    [SerializeField] List<TMP_Text> priceName;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < AllGuns.Count; i++)
        {
            buttonName[i].text = AllGuns[i].name;
            priceName[i].text = AllGuns[i].price.ToString();
        }
    }

    public void buyItem(int x)
    {
        if (playerData.weapons.Count >= 4)
        {
            text.text = "Guns reached limit";
        }
        else
        {
            if (AllGuns[x].price > playerData.Cash)
            {
                text.text = "You dont have enough cash";
            }
            else
            {
                for (int i = 0; i < playerData.weapons.Count; i++)
                {
                    if (AllGuns[x] == playerData.weapons[i])
                    {
                        AllGuns[x].owned = true;
                    }
                }

                if (AllGuns[x].owned == true)
                {
                    text.text = "Gun Exists";
                    StartCoroutine(display(text));
                }
                else
                {
                    playerData.weapons.Add(AllGuns[x]);
                    text.text = "Gun Added";
                    playerData.Cash -= AllGuns[x].price;
                    StartCoroutine(display(text));
                    AllGuns[x].owned = true;
                }
            }
        }
    }

    IEnumerator display(TMP_Text text)
    {
        yield return new WaitForSeconds(3f);
        text.text = "";
    }

    public void removeItem(int x)
    {
        for (int i = 0; i < playerData.weapons.Count; i++)
        {
            if (AllGuns[x] == playerData.weapons[i])
            {
                AllGuns[x].owned = true;
            }
        }

        if (!AllGuns[x].owned)
        {
            text.text = "Gun does not exist";
            StartCoroutine(display(text));
        }
        else
        {
            playerData.weapons.Remove(AllGuns[x]);
            text.text = "Gun removed";
            StartCoroutine(display(text));
            AllGuns[x].owned = false;
        }
    }

    public void checkIfOwned()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
