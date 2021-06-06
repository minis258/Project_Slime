//#### Created by Minh #####
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void LoadScenes(string _scene)
    {
        SceneManager.LoadScene(_scene);
    }


}
