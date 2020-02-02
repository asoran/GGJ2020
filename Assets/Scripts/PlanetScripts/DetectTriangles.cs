using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTriangles : MonoBehaviour {
    public Camera cam;

    void Start () {
        cam = GetComponent<Camera> ();
    }

    void Update () {
        Vector3 vr = GetRealCords ();
        Debug.Log (vr);
    }

    public static Vector3 GetRealCords () {
        /// <summary>
        /// Translate current Mouse X/Y into realworld cords using raycast
        /// </summary>
        /// <returns>Vector3 realworld cords (0,0,0) for invalid queries</returns>
        /// 

        Ray xray = Camera.main.ScreenPointToRay (Input.mousePosition);

        RaycastHit hit;

        int mask = 0;
        mask |= (1 << LayerMask.NameToLayer ("Building"));
        mask |= (1 << LayerMask.NameToLayer ("Trees"));
        mask |= (1 << LayerMask.NameToLayer ("nodes"));
        mask |= (1 << LayerMask.NameToLayer ("Ignore Raycast"));
        mask = ~mask;

        if (Physics.Raycast (xray, out hit, 1000, mask)) {
            return hit.point;

        }

        return Vector3.zero;
    }
}