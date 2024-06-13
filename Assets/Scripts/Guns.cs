using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Gun", menuName = "Weapons")]
public class Guns : ScriptableObject
{
    [Header("Info")]
    public new string name;
    public int price;
    public bool owned;

    [Header("Shooting")]
    public float damage;
    public float maxDistance;
    public GameObject bullet;

    [Header("Reloading")]
    public float magazinSize;
    public float currentAmmo;

    public float fireRate;
    public float reloadTime;

    [HideInInspector] public bool reloading;
}
