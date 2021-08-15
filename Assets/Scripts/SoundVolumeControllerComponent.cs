using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoundVolumeControllerComponent : MonoBehaviour
{   
    private AudioSource audioSrc;
    private float volume = 1f;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        audioSrc.volume = volume;
    }

    public void SetVolume(float vol)
    {
        volume = vol;
    }
}
