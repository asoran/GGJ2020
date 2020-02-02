using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Asteroid : Random_Event
{
    public override void doSomething(){
        if(possible){
            this.variables.text_event.text="Un astéroide s'est écrasé";
            this.variables.addToScore(-25);
            this.variables.die(20);
            planet.SetActive(true);
            possible=false;
        }
    }
}
