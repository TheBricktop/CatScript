using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SheepScript
{

    public class Waypoint : SheepScriptBase
    {
        public Mesh selectedMesh;
        // Start is called before the first frame update

        private void OnDrawGizmos()
        {
            if (selectedMesh != null) 
            {
                Gizmos.DrawWireMesh(selectedMesh, -1, transform.position, transform.rotation, transform.lossyScale);
            }
            else{
                Gizmos.DrawWireSphere(transform.position,transform.localScale.magnitude);
            }
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, transform.position + transform.forward);
        }
    }
}
