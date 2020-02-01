using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_boisement : Action
{
    protected override void doAction()
    {
        int value= Random.Range(1,100);
        this.variables.addToScore(value <= 60 ? 15 : (value >= 96 ? -20 : 0));
        if(value>=96){
            for(int i=0;i<20;i++){
                this.variables.reproduce();
            }
        }
    }
}
