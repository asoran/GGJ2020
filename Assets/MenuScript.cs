using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

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
        // Si lancer depuis Unity
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        // Sinon Quitter le jeux si c'est un build
        Application.Quit();
#endif
    }
}
