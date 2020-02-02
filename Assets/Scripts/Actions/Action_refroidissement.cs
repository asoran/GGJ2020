using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_refroidissement : Action
{
    private bool used = false;
    protected override void doAction()
    {
        used = true;
        int value= Random.Range(1,100);
        this.variables.addToScore(value <= 30 ? 70 : -50);
        if(value<=30) this.variables.die(50);
    }

    public override bool isActive() {
        return !used && this.variables.getScore() >= 65;
    }
}
