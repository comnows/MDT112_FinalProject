using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level;
    public int maxlevel;
    public int currentEXP;
    public int maxEXP;
    public int health;
    public int atkDmg;

    public PlayerData (Player player)
    {
        level = player.level;
        currentEXP = player.currentEXP;
        maxEXP = player.maxEXP;
        health = player.health;
        atkDmg = player.atkDmg;
    }
}
