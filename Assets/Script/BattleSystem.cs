using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    unit playerUnit;
    unit enemyUnit;

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
        }
        else if(state == BattleState.LOST)
        {
            dialogueText.text = "You were defeated by " + enemyUnit.unitName + "!!!";
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
        playerUnit.Heal(20);

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
