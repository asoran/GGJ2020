using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuScript : MonoBehaviour
{
    public void Play()
    {
        LevelChanger.instance.gameObject.SetActive(true);
        LevelChanger.instance.FadeToNextLevel();
    }
}
