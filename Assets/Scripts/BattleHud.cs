using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHud : MonoBehaviour
{

    public TMP_Text m_NameText;
    public TMP_Text m_LevelText;
    public Slider m_HPSlider;

    public void SetHUD(Slime _unit)
    {
        m_NameText.text = _unit.m_SlimeName;
        m_LevelText.text = "Lvl. " + _unit.m_SlimeLevel;
        m_HPSlider.maxValue = _unit.m_SlimeMaxHP;
        m_HPSlider.value = _unit.m_SlimeCurrentHP;
    }

    public void SetHP(int _hp)
    {
        m_HPSlider.value = _hp;
    }
}
