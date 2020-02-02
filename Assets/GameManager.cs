using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isCinematicOpeningEnded = false;
    public GameObject Buttons;

    private void Start()
    {
        Settings.gameManager = this;
    }

    private void Update()
    {
        if (isCinematicOpeningEnded)
        {
            Buttons.SetActive(true);
        }
    }
}
