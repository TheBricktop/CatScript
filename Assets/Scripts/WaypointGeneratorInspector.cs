using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WaypointGenerator))]

public class WaypointGeneratorInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        WaypointGenerator generator = (WaypointGenerator)target;
        if (GUILayout.Button("Create Waypoint"))
        {
            generator.CreateWaypoint();
        }

    }
}
