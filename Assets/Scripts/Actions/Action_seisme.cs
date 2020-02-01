using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_seisme : Action
{
    protected override void doAction()
    {
        int value= Random.Range(1,100);
        int good= Random.Range(5,15);
        this.variables.addToScore(value <= 40 ? good : (value >= 90 ? -10 : 0));
    }
}
