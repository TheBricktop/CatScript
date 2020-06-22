using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SheepScript
{

    public class Action : SheepScriptBase
    {
        /// <summary>
        /// virtual (extendable) function that actually performs the action
        /// </summary>
        public enum ActionState { start, stay, end };

        private ActionState currentState = ActionState.end;

        public ActionState CurrentState
        {
            get => currentState;
            set
            {
                if (currentState != value)
                {
                    StateChanged();
                }

                currentState = value;
                Debug.Log(this.name + "CurrentState = " + "" + currentState);
            }
        }

        public virtual void StartAction()
        {
            if (CurrentState == ActionState.end)
            {
                CurrentState = ActionState.start;
            }
            else
            {
                CurrentState = ActionState.stay;
            }

        }
        public virtual void EndAction()
        {
            CurrentState = ActionState.end;
        }

        public virtual void StateChanged()
        {

        }
    }
}
