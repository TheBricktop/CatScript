using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWaypoint : MonoBehaviour
{
    
    public float fov;
    public float maxRange;
    public float minRange;
    public float aspect;

    private void OnDrawGizmos()
    {

        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawFrustum( Vector3.zero,  fov,  maxRange,  minRange,  aspect);

    }
}
