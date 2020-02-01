using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Volcan : Action
{
    protected override void doAction()
    {
        this.variables.addToScore(Random.Range(-20, 20));
    }

    protected override void start()
    {
        text_button.text = "Volcan";
    }
}
