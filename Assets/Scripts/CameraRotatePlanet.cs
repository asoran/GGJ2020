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

        /*xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        yRotation -= mouseX;
        yRotation = Mathf.Clamp(yRotation, 0f, 360f);*/

        Vector3 distance = new Vector3(mouseX, mouseY, mouseX + mouseY);

        //transform.position = new Vector3(50 * Mathf.Cos(mouseX / 2), 50 * Mathf.Cos(mouseY / 2), 0);
        //transform.position = new Vector3(mouseX, mouseY, 0) + transform.position;

        //Vector3 p = transform.position;
        //transform.position = new Vector3(mouseX + p.x, mouseY + p.y, 4);

        //Vector3 p = transform.position;

        //Quaternion.RotateTowards(Quaternion.identity, planet.transform.rotation, 2f);
        //transform.position = new Vector3(mouseX, mouseY, mouseX + mouseY) + transform.position;

        //print("bruh : " + mouseX);
        //print(transform.position.x);

        Vector3 p = transform.position;

        //if (mouseX > 0.01f) {
        //    print("bruh : " + mouseX);
        //    print(transform.position.x);
        //    //transform.position += new Vector3(mouseX, 0, 0);
        //    transform.position = new Vector3(4f * Mathf.Sin((transform.position.x+mouseX)/9f), transform.position.y, transform.position.z);

        //}
        //transform.LookAt(planet.transform);
        transform.RotateAround(planet.transform.position, Vector3.down, mouseX * Time.deltaTime * mouseSensibility);
        transform.RotateAround(planet.transform.position, Vector3.right, mouseY * Time.deltaTime * mouseSensibility);
    }
}
