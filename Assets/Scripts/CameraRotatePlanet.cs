using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotatePlanet : MonoBehaviour
{
    public GameObject planet;
    public float mouseSensibility = 2f;

    public List<GameObject> followingCam;

    private Camera camGirl;
    private Vector3 offset;
    private float xRotation = 0f;
    private float yRotation = 0f;
    private void Start()
    {
        camGirl = GetComponent<Camera>();
        offset = planet.transform.position - camGirl.gameObject.transform.position;
    }

    private void LateUpdate()
    {

        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensibility;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensibility;

        bool isDown = Input.GetMouseButton(0);

        if(isDown) {

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                print("raycast");
                if(hit.collider.gameObject == planet) {
                    print("collider");
                    transform.RotateAround(planet.transform.position, transform.up, mouseX);
                    transform.RotateAround(planet.transform.position, -transform.right, mouseY);
                    //transform.LookAt(planet.transform.position, transform.up);
                    foreach (GameObject go in followingCam) {
                        go.transform.RotateAround(planet.transform.position, transform.up, mouseX);
                        go.transform.RotateAround(planet.transform.position, -transform.right, mouseY);
                    }
                }
            }
        }

    }
}
