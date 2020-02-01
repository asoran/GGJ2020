using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomManager : MonoBehaviour
{
    public List<Random_Event> events;
    protected Variables variables;
    private float randomEvent = 20.0f;
    private void Update()
    {
        randomEvent -= Time.deltaTime;
         if(randomEvent < 0)
         {
             int i = Random.Range(0, events.Count);
             Random_Event a = events[i];
             a.doSomething();
             randomEvent=10.0f;
         }else if(randomEvent < 4.0f){
             this.variables.text_event.text="";
         }
        
    }
    private void Start()
    {
        variables=GameObject.FindGameObjectWithTag("VariableObject").GetComponent<Variables>();
    }
}
