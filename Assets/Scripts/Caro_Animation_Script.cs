using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caro_Animation_Script : MonoBehaviour
{
    public GameObject Archer;
    public GameObject Fighter;

    private Animation p_Anim;

    // Start is called before the first frame update
    void Start()
    {
        p_Anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        p_Anim.Stop();
        p_Anim.Play("Archer_Idle");
    }
    public void PlayArcherAttack()
    {
        p_Anim.Stop();
        p_Anim.Play("Archer_Attack");
    }
    public void PlayArcherDeath()
    {
        p_Anim.Stop();
        p_Anim.Play("Archer_Death");
    }
    public void PlayFighterIdle()
    {
        p_Anim.Stop();
        p_Anim.Play("Fighter_Idle");
    }
    public void PlayFighterAttack()
    {
        p_Anim.Stop();
        p_Anim.Play("Fighter_Attack");
    }
    public void PlayFighterDeath()
    {
        p_Anim.Stop();
        p_Anim.Play("Fighter_Death");
    }
}
