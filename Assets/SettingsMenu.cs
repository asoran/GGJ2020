using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public TextMeshProUGUI volume_text;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);

        volume_text.text = volume.ToString();
    }
}
