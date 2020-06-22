using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SheepScript
{
    /// <summary>
    /// Detector just fires up events as long as the prerequisites are met
    /// </summary>
    public class Detector : SheepScriptBase
    {
        [System.Serializable]
        public class detectorEvent : UnityEvent { }
        public enum detectorState {start, stay, end};
        public detectorEvent detectorStartEvent;
        public detectorEvent detectorStayEvent;
        public detectorEvent detectorEndEvent;
        private detectorState currentState = detectorState.end;

        public detectorState CurrentState 
        {
            get => currentState;
            // if the value of CurrenState is changed the appropriate event are called if they arent null 
            set
            {
                // the '?' acts as null conditional, it checks if the event isnt null
                if (value == detectorState.start)
                {
                    detectorStartEvent?.Invoke();
                }else
                if (value == detectorState.stay)
                {
                    detectorStayEvent?.Invoke();
                }else
                if (value == detectorState.end)
                {
                    detectorEndEvent?.Invoke();
                }
                currentState = value;

                Debug.Log(this.name + "CurrentState = " + "" + currentState);
            }  
        }


    }
}

