using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Pollution : Random_Event {
    public override void doSomething () {
        this.variables.text_event.text = "La planête est pollué";
        this.variables.addToScore (-5);
        this.variables.die (1);
    }
}