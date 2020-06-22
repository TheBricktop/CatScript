using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SheepScript
{
    [RequireComponent(typeof(Animator))]
    /// <summary>
    /// allows easier interaction with animator graph
    /// </summary>
    public class PlayAnimation : Action
    {
        private Animator animator;
        
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        public void SetTrigger(string _name )
        {
            animator.SetTrigger(_name);
        }
    }
}
