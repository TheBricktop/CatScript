using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SheepScript
{
    //TODO : think about it
    public class MoveToTarget : Action
    {
        public AnimationCurve interpolation;
        public float speed = 0.1f;
        [SerializeField]
        private float currentTime = 0.0f;
        public Transform target;
        private Vector3 initialPos;
        private Quaternion initialRot;
        private Vector3 initialScale;

        void Start()
        {
            initialPos = transform.position;
            initialRot = transform.rotation;
            initialScale = transform.localScale;

        }


        void FixedUpdate()
        {
            if (CurrentState == ActionState.stay)
            {
                if (currentTime < 1)
                {
                    currentTime += speed;
                    currentTime = Mathf.Clamp01(currentTime);

                }
            }

            if (CurrentState == ActionState.end)
            {
                if (currentTime > 0)
                {
                    currentTime -= speed;
                    currentTime = Mathf.Clamp01(currentTime);
                }
            }
            UpdateTransform(currentTime);

        }

        private void UpdateTransform(float _direction)
        {
            transform.position = Vector3.Lerp(initialPos, target.position, interpolation.Evaluate(_direction));
            transform.rotation = Quaternion.Lerp(initialRot, target.rotation, interpolation.Evaluate(_direction));
            transform.localScale = Vector3.Lerp(initialScale, target.localScale, interpolation.Evaluate(_direction));
        }
    }
}
