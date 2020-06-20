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
    public int healAmount = 20;

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
        healAmount = PlayerData.healAmount;
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
            healAmount = 25;
            SavePlayer();
            break;

            case 3:
            currentEXP -= maxEXP;
            maxEXP = 150;
            health = 150;
            atkDmg = 50;
            healAmount = 30;
            SavePlayer();
            break;

            case 4:
            currentEXP -= maxEXP;
            maxEXP = 200;
            health = 180;
            atkDmg = 60;
            healAmount = 35;
            SavePlayer();
            break;

            case 5:
            currentEXP -= maxEXP;
            maxEXP = 300;
            health = 200;
            atkDmg = 70;
            healAmount = 40;
            SavePlayer();
            break;

            case 6:
            currentEXP -= maxEXP;
            maxEXP = 500;
            health = 250;
            atkDmg = 85;
            healAmount = 50;
            SavePlayer();
            break;

            case 7:
            currentEXP -= maxEXP;
            maxEXP = 1000;
            health = 300;
            atkDmg = 100;
            healAmount = 60;
            SavePlayer();
            break;

            case 8:
            currentEXP -= maxEXP;
            maxEXP = 1500;
            health = 350;
            atkDmg = 110;
            healAmount = 80;
            SavePlayer();
            break;

            case 9:
            currentEXP -= maxEXP;
            maxEXP = 2000;
            health = 400;
            atkDmg = 115;
            healAmount = 100;
            SavePlayer();
            break;

            case 10:
            currentEXP = 1;
            maxEXP = 1;
            health = 500;
            atkDmg = 120;
            healAmount = 120;
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
