using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private bool isCinematicOpeningEnded;

    private void Start()
    {
        Settings.gameManager = this;
        isCinematicOpeningEnded = false;
    }

}
