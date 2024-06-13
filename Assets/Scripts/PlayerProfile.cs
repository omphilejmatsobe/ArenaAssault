using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerProfile", menuName = "Player/Profile")]
public class PlayerProfile : ScriptableObject
{
    [Header("Player Info")]
    public string name;
    public int XP;
    public List<int> LevelsUnlocked;
    public List<Guns> weapons;
    public List<Guns> superActions;
}