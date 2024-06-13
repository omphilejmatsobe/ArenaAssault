using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SuperAction", menuName = "Actions/SuperAction")]
public class SuperAction : ScriptableObject
{
    [Header("Info")]
    public new string name;
    public bool owned;
    public int amount;

    [Header("Damage")]
    public int damage;
    public int rechargeTime;
}
