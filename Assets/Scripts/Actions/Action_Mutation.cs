using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Mutation : Action {
    protected override void doAction () {
        int value = Random.Range (1, 100);
        if (value >= 97) this.variables.mutationEnd ();
        else this.variables.addToScore (value <= 60 ? 10 : 0);
        if (value <= 60) this.variables.die (4);
    }
}