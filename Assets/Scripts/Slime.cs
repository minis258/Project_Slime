using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{

    public string m_SlimeName;
    public int m_SlimeLevel;

    //Stats
    public int m_SlimeStrength;
    public int m_SlimeDefense;
    public int m_SlimeMaxHP;
    public int m_SlimeCurrentHP;

    public float m_Hunger;

    public bool b_TakeDamage(int _dmg)
    {
        m_SlimeCurrentHP -= _dmg;

        if(m_SlimeCurrentHP <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
