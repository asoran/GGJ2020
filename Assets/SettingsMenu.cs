using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public TextMeshProUGUI volume_text;

    private void Start() {
        volume_text.text = "50%";
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);

        volume_text.text = (volume * 100).ToString() + "%";
    }
}
