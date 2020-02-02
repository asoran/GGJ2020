using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Vector3 newDesiredPositionIn;
    public Vector3 newDesiredPositionOut;
    public void Start()
    {
        StartCoroutine(LerpFromTo(transform.position, newDesiredPositionIn, 2f));
    }

    IEnumerator LerpFromTo(Vector3 pos1, Vector3 pos2, float duration)
    {
        for (float t = 0f; t < duration; t += Time.deltaTime)
        {
            transform.position = Vector3.Lerp(pos1, pos2, t / duration);
            yield return 0;
        }
        transform.position = pos2;
        StartCoroutine(LerpFinalFromTo(transform.position, newDesiredPositionOut, 1f));
    }

    IEnumerator LerpFinalFromTo(Vector3 pos1, Vector3 pos2, float duration)
    {
        for (float t = 0f; t < duration; t += Time.deltaTime)
        {
            transform.position = Vector3.Lerp(pos1, pos2, t / duration);
            yield return 0;
        }
        transform.position = pos2;
        Settings.gameManager.isCinematicOpeningEnded = true;
    }

}
