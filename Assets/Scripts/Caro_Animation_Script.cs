//###### Created by Minh ####
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This Script is only for the artist Caro build only
/// </summary>
public class Caro_Animation_Script : MonoBehaviour
{
    public GameObject Archer;
    public GameObject Fighter;

    public GameObject Start_Buttons;
    public GameObject Archer_Anim_Buttons;
    public GameObject Fighter_Anim_Buttons;

    public void Activate_Archer_Buttons()
    {
        Start_Buttons.SetActive(false);
        Fighter_Anim_Buttons.SetActive(false);
        Archer_Anim_Buttons.SetActive(true);
        Activate_Archer();
    }
    public void Activate_Fighter_Buttons()
    {
        Start_Buttons.SetActive(false);
        Archer_Anim_Buttons.SetActive(false);
        Fighter_Anim_Buttons.SetActive(true);
        Activate_Fighter();
    }
    public void Back_Button()
    {
        Archer_Anim_Buttons.SetActive(false);
        Fighter_Anim_Buttons.SetActive(false);
        Fighter.SetActive(false);
        Archer.SetActive(false);
        Start_Buttons.SetActive(true);
    }

    public void Activate_Archer()
    {
        Fighter.SetActive(false);
        Archer.SetActive(true);
    }

    public void Activate_Fighter()
    {
        Archer.SetActive(false);
        Fighter.SetActive(true);
    }

    public void PlayArcherIdle()
    {
        Archer.GetComponent<Animator>().Play("Archer_Idle");
    }
    public void PlayArcherAttack()
    {
        Archer.GetComponent<Animator>().Play("Archer_Attack");
    }
    public void PlayArcherDeath()
    {
        Archer.GetComponent<Animator>().Play("Archer_Death");
    }
    public void PlayFighterIdle()
    {
        Fighter.GetComponent<Animator>().Play("Fighter_Idle");
    }
    public void PlayFighterAttack()
    {
        Fighter.GetComponent<Animator>().Play("Fighter_Attack");
    }
    public void PlayFighterDeath()
    {
        Fighter.GetComponent<Animator>().Play("Fighter_Death");
    }
    public void Quit_Game()
    {
        Application.Quit();    
    }
}
