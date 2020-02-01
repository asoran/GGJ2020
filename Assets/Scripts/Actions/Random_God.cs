using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_God : Random_Event
{
    public override void doSomething(){
        this.variables.text_event.text="Dieu a fait un miracle";
        int value= Random.Range(1,100);
        this.variables.addToScore(-15);
        this.variables.die(500);   
    }
}
