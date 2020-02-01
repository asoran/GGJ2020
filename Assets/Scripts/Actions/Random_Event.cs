using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Random_Event : MonoBehaviour
{
    protected Variables variables;
    public abstract void doSomething();
    private void Start()
    {
        variables=GameObject.FindGameObjectWithTag("VariableObject").GetComponent<Variables>();
    }
}
