using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotatePlanet : MonoBehaviour
{
    public GameObject planet;
    public float mouseSensibility = 2f;
    public float scrollSensibility= 100f;
    public List<GameObject> followingCam;
    public float limitFrontZoom = 3.5f;
    public float limitBackZoom = 30f;

    private Camera camGirl;
    private Vector3 offset;

    private void Start()
    {
        camGirl = GetComponent<Camera>();
        offset = planet.transform.position - camGirl.gameObject.transform.position;
    }

    private void LateUpdate()
    {

        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensibility;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensibility;
        float scroll = Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * scrollSensibility;

        bool isDown = Input.GetMouseButton(0);

        if(isDown && Settings.gameManager.isCinematicOpeningEnded) {

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                if(hit.collider.gameObject == planet) {
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
        Vector3 diffcamplan = ((Vector3.Scale(transform.position, transform.forward)) - (Vector3.Scale(planet.transform.position, transform.forward)));
        Vector3 limit = (Vector3.Scale(new Vector3(100, 100, 100), transform.forward));
   
        //if (scroll != 0f && ( ((Vector3.Scale(transform.position, transform.forward)) - (Vector3.Scale(planet.transform.position, transform.forward)) )).magnitude < (Vector3.Scale(new Vector3(100,100,100), transform.forward)).magnitude   || -Mathf.Sign(scroll) == Mathf.Sign((transform.InverseTransformPoint(transform.position) - transform.InverseTransformPoint(planet.transform.position)).z) )
        if (Settings.gameManager.isCinematicOpeningEnded)
        {
            if (scroll != 0f && (transform.InverseTransformPoint(planet.transform.position).z < limitBackZoom && transform.InverseTransformPoint(planet.transform.position).z > limitFrontZoom) || Mathf.Sign(scroll) == Mathf.Sign(transform.InverseTransformPoint(planet.transform.position).z - limitFrontZoom))
            {
                transform.position += transform.forward * scroll;
            }
        }
    }
}
