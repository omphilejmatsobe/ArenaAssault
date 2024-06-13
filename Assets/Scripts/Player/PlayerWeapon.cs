using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [Header("GameManager")]
    [SerializeField] GameManager gameManager;

    [Header("Weapon")]
    [SerializeField] Guns weapon;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        weapon = gameManager.playerData.weapons[0];
    }

    public void shoot()
    {
        if (weapon.currentAmmo > 0)
        {
            weapon.currentAmmo--;
        }

        gameManager.playerData.XP++;
    }

    public void reload()
    {
        ;
    }

    IEnumerator reloading()
    {
        weapon.reloading = true;
        yield return new WaitForSeconds(weapon.reloadTime);
        reload();
        weapon.reloading = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) /*&& !weapon.reloading*/)
            shoot();

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!weapon.reloading)
            {
                reload();
            }
        }
    }
}
