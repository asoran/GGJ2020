using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// physics to 0 to use.
[RequireComponent(typeof(SphereCollider))]
public class Gravity : MonoBehaviour
{
    [SerializeField] float forceGravitionelle= 50.0f;// à moduler
    SphereCollider gravityRegions;
    SphereCollider planet;
    float distanceAttraction;

    void Awake(){
        gravityRegions= GetComponent<SphereCollider>();
        gravityRegions.isTrigger= true;
        planet= GetComponentInChildren<SphereCollider>();
        distanceAttraction= gravityRegions.radius - planet.radius;
    }
    // Start is called before the first frame update
    void onTriggerStay(Collider other){
        if(other.attachedRigidbody){
            float intensite= Vector3.Distance(transform.position,other.transform.position)/gravityRegions.radius;
            other.attachedRigidbody.AddForce((transform.position-other.transform.position)* intensite*forceGravitionelle*Time.deltaTime);
            
        }
    }
}
