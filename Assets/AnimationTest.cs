using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    private Animator animate;

    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
    }
}
