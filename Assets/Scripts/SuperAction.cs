using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SuperAction", menuName = "Actions/SuperAction")]
public class SuperAction : ScriptableObject
{
    public new string name;
    public int amount;
    public int damage;
    public int rechargeTime;
}
