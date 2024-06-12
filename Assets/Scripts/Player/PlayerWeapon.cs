using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [Header("Bullet")]
    [SerializeField] GameObject bullet;

    [Header("Weapon")]
    [SerializeField] GameObject Weapon;

    // Start is called before the first frame update
    void Start()
    {
        Weapon = this.gameObject;
    }

    public void shoot()
    {
        Debug.Log("Shooting");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            shoot();
    }
}
