using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//Controls the audio slider found in the settings menu

public class SettingsMenu : MonoBehaviour
{
    //To be able to select the audioMixer which was Master
    public AudioMixer audioMixer;

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
