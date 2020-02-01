using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotatePlanet : MonoBehaviour
{
    public GameObject planet;
    public float mouseSensibility = 2f;

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
        float mouseX = Input.GetAxis("Mouse X") * mouseSensibility;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensibility;

        bool isDown = Input.GetMouseButton(0);

        if(isDown) {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                if(hit.collider.gameObject == planet) {
                    transform.RotateAround(planet.transform.position, transform.up, mouseX * Time.deltaTime * mouseSensibility);
                    transform.RotateAround(planet.transform.position, -transform.right, mouseY * Time.deltaTime * mouseSensibility);
                }
            }
        }

    }
}
