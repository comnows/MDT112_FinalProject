using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 1;
    public int maxlevel = 10;
    public int currentEXP = 0;
    public int maxEXP = 100;
    public int health = 100;
    public int atkDmg = 25;

    void Start()
    {
        LoadPlayer();
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        currentEXP = data.currentEXP;
        maxEXP = data.maxEXP;
        health = data.health;
        atkDmg = data.atkDmg;
    }

    public void gainEXP(int exp)
    {
        currentEXP += exp;
        if(currentEXP >= maxEXP && level <= 9)
        {
            level += 1;
            switch(level)
            {
            case 2:
            currentEXP -= maxEXP;
            maxEXP = 125;
            health = 120;
            atkDmg = 35;
            SavePlayer();
            break;

            case 3:
            currentEXP -= maxEXP;
            maxEXP = 125;
            health = 120;
            atkDmg = 35;
            SavePlayer();
            break;

            case 4:
            currentEXP -= maxEXP;
            maxEXP = 125;
            health = 120;
            atkDmg = 35;
            SavePlayer();
            break;

            case 5:
            currentEXP -= maxEXP;
            maxEXP = 125;
            health = 120;
            atkDmg = 35;
            SavePlayer();
            break;

            case 6:
            currentEXP -= maxEXP;
            maxEXP = 125;
            health = 120;
            atkDmg = 35;
            SavePlayer();
            break;

            case 7:
            currentEXP -= maxEXP;
            maxEXP = 125;
            health = 120;
            atkDmg = 35;
            SavePlayer();
            break;

            case 8:
            currentEXP -= maxEXP;
            maxEXP = 125;
            health = 120;
            atkDmg = 35;
            SavePlayer();
            break;

            case 9:
            currentEXP -= maxEXP;
            maxEXP = 125;
            health = 120;
            atkDmg = 35;
            SavePlayer();
            break;

            case 10:
            currentEXP -= maxEXP;
            maxEXP = 125;
            health = 120;
            atkDmg = 35;
            SavePlayer();
            break;
            }
        }
        else
        {
            SavePlayer();
        }
    }
}
