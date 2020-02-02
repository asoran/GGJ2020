using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parasite : MonoBehaviour
{
    public GameObject character;
    public GameObject planet;

    public void Run()
    {
        StartCoroutine(Populate(5f));
    }


    IEnumerator Populate(float duration)
    {
        for (float t = 0f; t < duration; t += Time.deltaTime)
        {
            Vector3 spawnPosition = Random.onUnitSphere * ((planet.transform.GetComponent<Planet>().GetComponent<ShapeSettings>().planetRadius) + character.transform.localScale.y * 0.5f) + planet.transform.position;
            Quaternion spawnRotation = Quaternion.identity;
            GameObject newCharacter = Instantiate(character, spawnPosition, spawnRotation) as GameObject;
            newCharacter.transform.LookAt(planet.transform);
            newCharacter.transform.Rotate(-90, 0, 0);
            yield return 0;
        }
    }

}
