using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Tsunami : Action
{
    protected override void doAction()
    {
        int value= Random.Range(1,100);
        this.variables.addToScore(value <= 40 ? 20 : -25);
        if(value<=40) this.variables.die(13);
    }

    protected override void start()
    {
        text_button.text = "Tsunami";
    }
}
