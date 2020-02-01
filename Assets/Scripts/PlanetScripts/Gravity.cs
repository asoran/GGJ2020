using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// physics to 0 to use.
[RequireComponent(typeof(SphereCollider))]
public class Gravity : MonoBehaviour
{
    [SerializeField] float forceGravitionelle= 5.0f;// à moduler
    public SphereCollider gravityRegions;
    public SphereCollider planet;
    float distanceAttraction;

    void Awake(){
        gravityRegions.isTrigger= true;
        distanceAttraction= gravityRegions.radius - planet.radius;
    }
    void OnTriggerStay (Collider other){
        if(other.attachedRigidbody){
            float intensite= Vector3.Distance(transform.position,other.transform.position)/gravityRegions.radius;
            other.attachedRigidbody.AddForce((transform.position-other.transform.position)* intensite*forceGravitionelle*Time.deltaTime);
        }
    }
}
