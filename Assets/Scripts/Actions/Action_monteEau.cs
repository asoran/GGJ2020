using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_monteEau : Action
{
    protected override void doAction()
    {
        int value= Random.Range(1,100);
        this.variables.addToScore(value <= 80 ? 2 : (value >= 97 ? -10 : 0));
        if(value<=80) this.variables.die(2);
    }
}

