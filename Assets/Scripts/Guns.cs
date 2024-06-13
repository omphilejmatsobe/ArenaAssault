using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Gun", menuName = "Weapons")]
public class Guns : ScriptableObject
{
    [Header("Info")]
    public new string name;

    [Header("Shooting")]
    public float damage;
    public float maxDistance;

    [Header("Reloading")]
    public float magazinSize;
    public float currentAmmo;

    public float fireRate;
    public float reloadTime;

    [HideInInspector] public bool reloading;
}
