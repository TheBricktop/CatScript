using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFolllower : MonoBehaviour
{
    public GameObject waypointsGenerator;
    public CameraWaypoint[] Waypoints;
    public int current = 0;
    public float moveSpeed;
    public float rotateSpeed;
    public bool rotateCamera = false;

    // Start is called before the first frame update
    void Start()
    {
        Waypoints = waypointsGenerator.GetComponentsInChildren<CameraWaypoint>();
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GoForward();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GoBack();
        }

        if (transform.position != Waypoints[current].transform.position )
        {
            UpdateTransform();
        }

        if (rotateCamera && transform.forward != Waypoints[current].transform.forward)
        {
            UpdateTransform();
        }

        //Debug.Log(Waypoints.Length);
    }

    /*
     * zmiana położenia
     */
     public void GoForward()
     {
        current++;
        if (current == Waypoints.Length)
        {
            current = 0;
        }
        current = Mathf.Clamp(current, 0, Waypoints.Length - 1);
     }

    public void GoBack()
    {
        current--;
        current = Mathf.Clamp(current, 0, Waypoints.Length - 1);
    }

    private void UpdateTransform()
    {
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[current].transform.position, moveSpeed);

        if (rotateCamera)
        {
            transform.forward = Vector3.RotateTowards(transform.forward, Waypoints[current].transform.forward, rotateSpeed, .001f);
        }
       
        //
        //transform.rotation = Quaternion.RotateTowards()
    }
}
