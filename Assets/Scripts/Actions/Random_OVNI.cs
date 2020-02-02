using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_OVNI : Random_Event {
    public override void doSomething () {
        this.variables.text_event.text = "Un Ovni est apparu";
        int value = Random.Range (1, 100);
        this.variables.addToScore (value <= 50 ? 5 : -5);
        if (value <= 50) {
            this.variables.reproduce ();
        } else {
            this.variables.die (5);
        }
        planet.SetActive (true);
        Debug.Log (planet.GetComponent<Animation> ());
        planet.GetComponent<Animation> ().Play ("ovniAnimator");
    }
}