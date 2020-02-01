using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_virus : Action
{
      protected override void doAction()
    {
        int value= Random.Range(1,100);
        int mutation= Random.Range(1,100);
        this.variables.addToScore(value <= 70 ? 35 : -9);
        if(value>70) this.variables.mutation(mutation/100);
    }
}
