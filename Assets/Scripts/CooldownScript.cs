using System.Collections;
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
        Image img = button.gameObject.GetComponent<Image>();
        Color tmp = img.color;
        tmp.a = 0f;
        img.color = tmp;
        yield return new WaitForSeconds(waitTime);
        tmp.a = 1f;
        img.color = tmp;
        button.interactable = true;
    }
}
