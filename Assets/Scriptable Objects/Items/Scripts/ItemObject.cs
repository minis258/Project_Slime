using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equip,
    Default
}
public abstract class ItemObject : ScriptableObject
{
    public GameObject m_Prefab;
    public ItemType m_Type;

    [TextArea(10, 20)]
    public string m_Description;

}
