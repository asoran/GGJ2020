using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Rechauffement : Action {
    protected override void doAction () {
        int value = Random.Range (1, 100);
        this.variables.addToScore (value <= 70 ? 50 : -70);
        if (value <= 70) this.variables.die (20);
        float persistence = planet.GetComponent<ShapeSettings> ().noiseLayers[0].noiseSettings.simpleNoiseSettings.persistence;

        if (persistence < 1.1) {
            planet.GetComponent<Planet> ().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.persistence += 0.10f;
            planet.GetComponent<Planet> ().GeneratePlanet ();
        }
    }

    public override bool isActive () {
        return this.variables.getScore () <= -65;
    }
}