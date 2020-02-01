using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Volcan : Action
{
    protected override void doAction()
    {
        int value= Random.Range(1,100);
        this.variables.addToScore(value <= 50 ? 20 : -20);
        if(value<=50) this.variables.die(15);
    }
}
