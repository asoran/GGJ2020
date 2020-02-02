using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_seisme : Action
{
    private bool secousse;
    private float time;
    protected override void doAction()
    {
        int value= Random.Range(1,100);
        int good= Random.Range(5,15);
        this.variables.addToScore(value <= 40 ? good : (value >= 90 ? -10 : 0));
        secousse=true;
        time=5;
    }
    private void Update()
    {
        if(secousse){
            time -= Time.deltaTime;
            foreach(Transform g in GetComponentsInChildren<Transform>()){
                Debug.Log("a");
                g.position = new Vector3( Random.Range(0,2) < 1 ? 0.5f : -0.5f, g.position.y, g.position.z);
            }
            if(time < 0)
            {
                foreach(Transform g in GetComponentsInChildren<Transform>()){
                    g.position=new Vector3( 0.0f, g.position.y, g.position.z);
                }
                secousse=false;
            }
        }
        
    }
}
