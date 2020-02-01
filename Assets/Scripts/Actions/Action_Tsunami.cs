using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Tsunami : Action
{
    protected override void doAction()
    {
        this.variables.addToParasite(Random.Range(-20, 20));
    }

    protected override void start()
    {
        text_button.text = "Tsunami";
    }
}
