using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_seisme : Action {
    private bool secousse = false;
    private float time = 0;

    private int MAX_SECOUSSES = 10;

    private bool shouldWait = false;

    protected override void doAction () {
        int value = Random.Range (1, 100);
        int good = Random.Range (5, 15);
        this.variables.addToScore (value <= 40 ? good : (value >= 90 ? -10 : 0));
        secousse = true;
        time = 5;

        List<Transform> plates = new List<Transform> (planet.GetComponentsInChildren<Transform> ());
        plates.RemoveAt (0);
        actionManager.doSeisme (plates, MAX_SECOUSSES);
    }
}