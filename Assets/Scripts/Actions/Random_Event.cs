using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Random_Event : MonoBehaviour
{
    protected Variables variables;
    public GameObject planet;
    public Sprite Logo;
    public abstract void doSomething();
    private void Start()
    {
        variables=GameObject.FindGameObjectWithTag("VariableObject").GetComponent<Variables>();
    }
}
