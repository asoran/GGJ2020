using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// physics to 0 to use.
[RequireComponent(typeof(SphereCollider))]
public class Gravity : MonoBehaviour
{
    [SerializeField] float forceGravitionelle = 50.0f; // à moduler
    public SphereCollider gravityRegions;
    public SphereCollider planet;
    void OnTriggerStay (Collider other) {
        if(other.attachedRigidbody){
            float intensite = Vector3.Distance(transform.position,
                other.transform.position) * forceGravitionelle * Time.deltaTime;

            other.attachedRigidbody.AddForce(
                intensite * (transform.position - other.transform.position)
            );
        }
    }
}
