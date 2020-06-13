using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SheepScript
{
    /// <summary>
    /// Simple input test for keyboard
    /// </summary>
    public class Key : Stimulus
    {
        public KeyCode inputKey;
        private void Update()
        {
            if (Input.GetKeyDown(inputKey))
            {
                CurrentState = stimulusState.start;
            }

            if (Input.GetKey(inputKey))
            {
                CurrentState = stimulusState.stay;
            }

            if (Input.GetKeyUp(inputKey))
            {
                CurrentState = stimulusState.end;
            }
        }
    }  
}

