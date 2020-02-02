﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CooldownScript : MonoBehaviour
{
    public readonly float waitTime = 2f;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
    }

    public void CoolDown()
    {
        StartCoroutine(Waiting());
    }

    private IEnumerator Waiting()
    {
        button.interactable = false;
        yield return new WaitForSeconds(waitTime);
        button.interactable = true;
    }
}
