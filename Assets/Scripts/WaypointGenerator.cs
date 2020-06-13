using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class WaypointGenerator : MonoBehaviour
{
    public GameObject waypoint;
    public CameraWaypoint[] waypoints;
    private Vector3 viewportPos;
    private Quaternion viewportRot;

   
   /// <summary>
   /// Takes sceneview camera and instantiates a camera waypoint
   /// </summary>
    public void CreateWaypoint()
    {
        var sceneView = SceneView.lastActiveSceneView;

        Vector3 position = sceneView.camera.transform.position;
        Quaternion rotation = sceneView.rotation;
        GameObject newWaypoint = Instantiate(waypoint,position,rotation,transform);

        updateNames();
    }

    public void updateNames()
    {
        waypoints = GetComponentsInChildren<CameraWaypoint>();

        for (int i = 0; i < waypoints.Length; i++)
        {
            waypoints[i].name = "Waypoint" + i;
        }
    }
}
