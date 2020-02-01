using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Nuclear : Random_Event
{
    public override void doSomething(){
        this.variables.text_event.text="Une bombe nucléaire a éclaté";
        this.variables.addToScore(-23);
        this.variables.die(5);
    }
}
