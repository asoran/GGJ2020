using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
    public Text textIntro;
    void Start () {
        StartCoroutine (LerpFromTo (0.0f, 1.0f, 2f));
    }

    IEnumerator LerpFromTo (float pos1, float pos2, float duration) {
        for (float t = 0f; t < duration; t += Time.deltaTime) {
            Color cText = textIntro.color;
            cText.a = Mathf.Lerp (pos1, pos2, t / duration);
            textIntro.color = cText;
            yield return 0;
        }
        StartCoroutine (FinalLerp (1.0f, 0.0f, 1f));
    }

    IEnumerator FinalLerp (float pos1, float pos2, float duration) {
        for (float t = 0f; t < duration; t += Time.deltaTime) {
            Color cText = textIntro.color;
            cText.a = Mathf.Lerp (pos1, pos2, t / duration);
            textIntro.color = cText;
            yield return 0;
        }
        textIntro.gameObject.SetActive (false);
    }
}