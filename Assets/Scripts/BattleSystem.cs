using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public enum EBattleState
{
    start,
    playerturn,
    enemyturn,
    won,
    lost
}
public class BattleSystem : MonoBehaviour
{
    public EBattleState m_State;

    public GameObject m_PlayerPrefab;
    public GameObject m_EnemyPrefab;

    public Transform m_PlayerBattleStation;
    public Transform m_EnemyBattleStation;

    Slime m_PlayerSlime;
    Slime m_EnemyUnit;

    public TMP_Text m_DialogueText;

    public BattleHud m_PlayerHUD;
    public BattleHud m_EnemyHUD;

    // Start is called before the first frame update
    void Start()
    {
        m_State = EBattleState.start;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        GameObject playerObject = Instantiate(m_PlayerPrefab, m_PlayerBattleStation);
        m_PlayerSlime = playerObject.GetComponent<Slime>();

        GameObject enemyObject = Instantiate(m_EnemyPrefab, m_EnemyBattleStation);
        m_EnemyUnit = enemyObject.GetComponent<Slime>();

        m_DialogueText.text = m_EnemyUnit.m_SlimeName + " appears.";
        m_PlayerHUD.SetHUD(m_PlayerSlime);
        m_EnemyHUD.SetHUD(m_EnemyUnit);

        yield return new WaitForSeconds(2f);

        m_State = EBattleState.playerturn;
        PlayerTurn();
        
    }

    private void PlayerTurn()
    {
        m_DialogueText.text = "What do you want to do?";
    }

    public void OnAttackButton()
    {
        if (m_State != EBattleState.playerturn)
        {
            return;
        }

        StartCoroutine(PlayerAttack());
    }

    IEnumerator PlayerAttack()
    {
        // Damage the enemy
        bool isDead = m_EnemyUnit.b_TakeDamage(m_PlayerSlime.m_SlimeStrength);

        m_EnemyHUD.SetHP(m_EnemyUnit.m_SlimeCurrentHP);
        m_DialogueText.text = m_PlayerSlime.m_SlimeName + " attacks!";

        yield return new WaitForSeconds(2f);

        // Check if enemy was killed
        if (isDead)
        {
            //end battle
            m_State = EBattleState.won;
            EndBattle();
        }
        else
        {
            // enemy turn
            m_State = EBattleState.enemyturn;
            StartCoroutine(EnemyTurn());
        }
    }

    private void EndBattle()
    {
        if (m_State == EBattleState.won)
        {
            m_DialogueText.text = "You won!";
        }
        else if (m_State == EBattleState.lost)
        {
            m_DialogueText.text = "You lost!";
        }
    }

    IEnumerator EnemyTurn()
    {
        m_DialogueText.text = m_EnemyUnit.m_SlimeName + " attacks!";
        
        yield return new WaitForSeconds(2f);

        bool isDead = m_PlayerSlime.b_TakeDamage(m_EnemyUnit.m_SlimeStrength);

        m_PlayerHUD.SetHP(m_PlayerSlime.m_SlimeCurrentHP);

        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            m_State = EBattleState.lost;
            EndBattle();
        }
        else
        {
            m_State = EBattleState.playerturn;
            PlayerTurn();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
