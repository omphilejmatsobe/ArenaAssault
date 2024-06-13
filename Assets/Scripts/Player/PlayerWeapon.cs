using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [Header("Bullet")]
    [SerializeField] GameObject bullet;

    [Header("Weapon")]
    [SerializeField] Guns weapon;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void shoot()
    {
        if (weapon.currentAmmo > 0)
        {

            weapon.currentAmmo--;
        }
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
        if (Input.GetKeyDown(KeyCode.Mouse0) && !weapon.reloading)
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
