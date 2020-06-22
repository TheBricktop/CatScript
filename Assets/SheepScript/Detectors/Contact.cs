using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SheepScript
{
    /// <summary>
    /// Detects collision and volume entry of objects with tag
    /// </summary>

    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(BoxCollider))]
    public class Contact : Detector
    {
        public bool withAnything = false;
        public string targetTag = "target";
        private bool insideVolume = false;
        private Rigidbody rigidbody;
        private Collider collider;
        /// <summary>
        /// Detect change in insideVolume variabla and changes the collider isTrigger option accordingly
        /// </summary>
        /// <value></value>
        public bool InsideVolume
        {
            get => insideVolume;

            set
            {
                if (value)
                {
                    collider.isTrigger = true;
                }
                else
                {
                    collider.isTrigger = false;
                }
            }
        }

        private void Start()
        {

            rigidbody = GetComponent<Rigidbody>();
            collider = GetComponent<Collider>();
            rigidbody.isKinematic = true;
            rigidbody.useGravity = false;
            InsideVolume = true;
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag(targetTag) || withAnything)
            {
                CurrentState = detectorState.start;

            }
        }
        private void OnCollisionStay(Collision other)
        {
            if (other.gameObject.CompareTag(targetTag) || withAnything)
            {
                CurrentState = detectorState.stay;

            }
        }
        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag(targetTag) || withAnything)
            {
                CurrentState = detectorState.end;

            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(targetTag) || withAnything)
            {
                CurrentState = detectorState.start;

            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag(targetTag) || withAnything)
            {
                CurrentState = detectorState.stay;

            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag(targetTag) || withAnything)
            {
                CurrentState = detectorState.end;

            }
        }
    }
}

