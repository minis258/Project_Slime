using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : ItemObject
{
    public float m_AttackBonus;
    public float m_DefenseBonus;
    public float m_SpeedBonus;

    public void Awake()
    {
        m_Type = ItemType.Equip;
    }
}
