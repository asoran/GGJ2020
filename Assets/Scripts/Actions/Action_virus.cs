using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Action_virus : Action
{
   
    protected override void doAction()
        {
         Color color1 = new Color(
             Random.Range(0f, 1f),
             Random.Range(0f, 1f),
             Random.Range(0f, 1f)
            );
          Color color2 = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );
          Color color3 = new Color(
             Random.Range(0f, 1f),
             Random.Range(0f, 1f),
             Random.Range(0f, 1f)
        );

          float time1 = Random.Range(0f, 1f);
          float time2 = Random.Range(0f, 1f);
          float time3 = Random.Range(0f, 1f);

         GradientColorKey GC1 = new GradientColorKey(color1, time1);
         GradientColorKey GC2 = new GradientColorKey(color2, time2);
         GradientColorKey GC3 = new GradientColorKey(color3, time3);
         GradientAlphaKey GA = new GradientAlphaKey(1, 0);
         GradientColorKey GCK1 = new GradientColorKey(color1, time1);
         GradientAlphaKey GAK = new GradientAlphaKey(1, 0);
         GradientColorKey[] GKS = new GradientColorKey[5];
         GradientAlphaKey[] GKAS = new GradientAlphaKey[5];
        GKS[0] = GC1;
        GKS[1] = GC2;
        GKS[2] = GC3;
        GKAS[0] = GA;
        int value = Random.Range(1, 100);
        int mutation = Random.Range(1, 100);
        this.variables.addToScore(value <= 70 ? 35 : -9);
        if (value > 70) this.variables.mutation(mutation / 100);
        Gradient gradiant = planet.GetComponent<ColourSettings>().gradient;
        gradiant.SetKeys(GKS, GKAS);
        planet.GetComponent<Planet>().GeneratePlanet();


    }
}
