using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Minigame_SmashedFruit : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// This script is only for despawning of bad fruits
    /// </summary>
    void Start()
    {
        Destroy(gameObject, 1f);
    }
}
