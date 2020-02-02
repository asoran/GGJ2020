using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuScript : MonoBehaviour
{
    private void Start()
    {
        AudioManager.instance.Play("Odyssey");
    }

    public void Play()
    {
        LevelChanger.instance.gameObject.SetActive(true);
        LevelChanger.instance.FadeToNextLevel();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
