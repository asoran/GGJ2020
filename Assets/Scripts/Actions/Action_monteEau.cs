using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_monteEau : Action
{
    protected override void doAction()
    {
        int value= Random.Range(1,100);
        this.variables.addToScore(value <= 80 ? 2 : (value >= 97 ? -10 : 0));
        if(value<=80) this.variables.die(2);
        Debug.Log(planet);
        float persistence = planet.GetComponent<ShapeSettings>().noiseLayers[0].noiseSettings.simpleNoiseSettings.persistence;

        if(persistence>0.05){
            planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.persistence-=0.10f;
            Debug.Log("--");
            planet.GetComponent<Planet>().GeneratePlanet();
        }
    }
}

