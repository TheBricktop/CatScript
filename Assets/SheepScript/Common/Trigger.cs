using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SheepScript
{
    public class Trigger : MonoBehaviour
    {
        public enum triggerState {start, stay, end};

        public triggerState currentState = triggerState.end;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public virtual void onTriggerStart(){
            
        }
    }
}

