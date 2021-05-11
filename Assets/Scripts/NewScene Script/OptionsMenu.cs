using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer MainAudioMixer;
    public void SetVolume(float Volume)
    {
        MainAudioMixer.SetFloat("MasterVolume", Volume);
    }
}
