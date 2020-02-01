using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// physics to 0 to use.
[RequireComponent(typeof(SphereCollider))]
public class Gravity : MonoBehaviour
{
    [SerializeField] float forceGravitionelle= 50.0f;// à moduler
    public SphereCollider gravityRegions;
    public SphereCollider planet;
    float distanceAttraction;

    void Awake(){
        gravityRegions.isTrigger= true;
        distanceAttraction= gravityRegions.radius - planet.radius;
    }
    void onTriggerStay (Collider other){
        Debug.Log("k");
        if(other.attachedRigidbody){
            float intensite= Vector3.Distance(transform.position,other.transform.position)/gravityRegions.radius;
            Debug.Log(intensite);
            other.attachedRigidbody.AddForce((transform.position-other.transform.position)* intensite*forceGravitionelle*Time.deltaTime);
        }
    }
}
