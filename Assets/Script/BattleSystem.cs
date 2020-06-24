using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    unit playerUnit;
    unit enemyUnit;

    Player player;
    public int exp;

    public Text dialogueText;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    public GameObject atkButton;
    public GameObject healButton;

    public BattleState state;
    
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetUpBattle());
    }

    IEnumerator SetUpBattle()
    {
        GameObject playerGO = playerPrefab;
        playerUnit = playerGO.GetComponent<unit>();

        player = playerGO.GetComponent<Player>();
        player.LoadPlayer();

        playerUnit.unitLevel = player.level;
        playerUnit.maxHP = player.health;
        playerUnit.currentHP = player.health;
        playerUnit.damage = player.atkDmg;
        playerUnit.healAmount = player.healAmount;

        GameObject enemyGO = enemyPrefab;
        enemyUnit = enemyGO.GetComponent<unit>();

        dialogueText.text = "A wild " + enemyUnit.unitName + " approach...";

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage); //Damage the enemy
        

        enemyHUD.SetHP(enemyUnit.currentHP);
        dialogueText.text = "The attack is succesful!";


        yield return new WaitForSeconds(2f);

        if(isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyUnit.unitName + " attack!";

        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);
        playerHUD.SetHP(playerUnit.currentHP);

        yield return new WaitForSeconds(1f);

        if(isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
        
    }

    void EndBattle()
    {
        if(state == BattleState.WON)
        {
            dialogueText.text = "You won the battle!!!";

            if(enemyUnit.unitName == "Big rabbit")
            {
                exp = 15;
                player.gainEXP(exp);
                SceneManager.LoadScene("Jungle");
            }
            if(enemyUnit.unitName == "Rhino")
            {
                exp = 20;
                player.gainEXP(exp);
                SceneManager.LoadScene("Jungle");
            }
            if(enemyUnit.unitName == "Spider")
            {
                exp = 25;
                player.gainEXP(exp);
                SceneManager.LoadScene("Jungle");
            }
            if(enemyUnit.unitName == "Nature Drake")
            {
                exp = 150;
                player.gainEXP(exp);
                SceneManager.LoadScene("story5");
            }
            if(enemyUnit.unitName == "Frog")
            {
                exp = 100;
                player.gainEXP(exp);
                SceneManager.LoadScene("Island");
            }
            if(enemyUnit.unitName == "Crab")
            {
                exp = 150;
                player.gainEXP(exp);
                SceneManager.LoadScene("Island");
            }
            if(enemyUnit.unitName == "Huclam")
            {
                exp = 300;
                player.gainEXP(exp);
                SceneManager.LoadScene("Island");
            }
            if(enemyUnit.unitName == "Miracle Drake")
            {
                exp = 9999999999;
                player.gainEXP(exp);
                SceneManager.LoadScene("story9");
            }
            if(enemyUnit.unitName == "Iguana")
            {
                exp = 40;
                player.gainEXP(exp);
                SceneManager.LoadScene("Desert");
            }
            if(enemyUnit.unitName == "Tiger")
            {
                exp = 50;
                player.gainEXP(exp);
                SceneManager.LoadScene("Desert");
            }
            if(enemyUnit.unitName == "Golem")
            {
                exp = 75;
                player.gainEXP(exp);
                SceneManager.LoadScene("Desert");
            }
            if (enemyUnit.unitName == "drought Drake")
            {
                exp = 500;
                player.gainEXP(exp);
                SceneManager.LoadScene("story7");
            }
        }
        else if(state == BattleState.LOST)
        {
            dialogueText.text = "You were defeated by " + enemyUnit.unitName + "!!!";
            SceneManager.LoadScene("GameOver");
        }
    }

    void PlayerTurn()
    {
        dialogueText.text = "Choose an action:";
        atkButton.SetActive(true);
        healButton.SetActive(true);
    }
    
    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
        return;

        StartCoroutine(PlayerAttack());
    }

    IEnumerator PlayerHeal()
    {
        playerUnit.Heal(playerUnit.healAmount);

        playerHUD.SetHP(playerUnit.currentHP);
        dialogueText.text = "You feel renewed strength!";

        yield return new WaitForSeconds(2f);

        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }

    public void OnHealButton()
    {
        if (state != BattleState.PLAYERTURN)
        return;

        StartCoroutine(PlayerHeal());
    }
    
}
