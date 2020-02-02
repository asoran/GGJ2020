using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomManager : MonoBehaviour {
    private bool possible;
    public List<Random_Event> events;
    protected Variables variables;
    private float randomEvent = 20.0f;
    private void Update () {
        randomEvent -= Time.deltaTime;
        if (randomEvent < 0) {
            int i = Random.Range (0, events.Count);
            Random_Event a = events[i];
            if (a.Logo != null && a.getDispo ()) {
                a.doSomething ();
                this.variables.logoRandom.sprite = a.Logo;
                Color temp = this.variables.logoRandom.color;
                temp.a = 1f;
                this.variables.logoRandom.color = temp;
            }
            randomEvent = 20.0f;
        } else if (randomEvent < 4.0f) {
            this.variables.text_event.text = "";
            Color temp = this.variables.logoRandom.color;
            temp.a = 0f;
            this.variables.logoRandom.color = temp;
        }

    }
    private void Start () {
        variables = GameObject.FindGameObjectWithTag ("VariableObject").GetComponent<Variables> ();
    }
}