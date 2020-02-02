using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isCinematicOpeningEnded = false;
    public GameObject Buttons;
    public Parasite para;

    private void Start()
    {
        Settings.gameManager = this;
        //para.Run();
    }

    private void Update()
    {
        if (isCinematicOpeningEnded)
        {
            Buttons.SetActive(true);
        }
    }


}
