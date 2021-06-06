//###### Created by Minh #####
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Set volumes
/// </summary>
public class Sound_Manager : MonoBehaviour
{
    private AudioSource p_AudioSource;

    private float p_Volume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        p_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckVolume();
    }

    private void CheckVolume()
    {
        p_AudioSource.volume = p_Volume;
    }

    public void SetVolume(float _vol)
    {
        p_Volume = _vol;
    }
}
