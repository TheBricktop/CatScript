using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SheepScript
{
    /// <summary>
    /// Simple input test for keyboard
    /// </summary>
    public class Key : Detector
    {
        public KeyCode inputKey;
        private void Update()
        {
            if (Input.GetKeyDown(inputKey))
            {
                CurrentState = detectorState.start;
            }

            if (Input.GetKey(inputKey))
            {
                CurrentState = detectorState.stay;
            }

            if (Input.GetKeyUp(inputKey))
            {
                CurrentState = detectorState.end;
            }
        }
    }  
}

