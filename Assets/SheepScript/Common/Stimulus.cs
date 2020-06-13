using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SheepScript
{
    public class Stimulus : MonoBehaviour
    {
        [System.Serializable]
        public class StimulusEvent : UnityEvent { }
        public enum stimulusState {start, stay, end};
        public StimulusEvent stimulusStartEvent;
        public StimulusEvent stimulusStayEvent;
        public StimulusEvent stimulusEndEvent;
        private stimulusState currentState = stimulusState.end;

        public stimulusState CurrentState 
        {
            get => currentState;
            // if the value of CurrenState is changed the appropriate event are called if they arent null 
            set
            {
                // the '?' acts as null conditional, it checks if the event isnt null
                if (value == stimulusState.start)
                {
                    stimulusStartEvent?.Invoke();
                }else
                if (value == stimulusState.stay)
                {
                    stimulusStartEvent?.Invoke();
                }else
                if (value == stimulusState.end)
                {
                    stimulusStartEvent?.Invoke();
                }
            }  
        }
        
        public virtual void onStimulusStart()
        {
            
        }

        public virtual void onStimulusStay()
        {
            
        }

        public virtual void onStimulusEnd()
        {
            
        }
    }
}

