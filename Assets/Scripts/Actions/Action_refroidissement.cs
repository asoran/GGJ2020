using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_refroidissement : Action
{
    protected override void doAction()
    {
        int value= Random.Range(1,100);
        this.variables.addToScore(value <= 30 ? 70 : -50);
        if(value<=30) this.variables.die(50);
    }
}
