using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_war : Random_Event {
    public override void doSomething () {
        this.variables.text_event.text = "Une guerre a éclaté";
        this.variables.addToScore (-9);
        this.variables.die (2);
    }
}