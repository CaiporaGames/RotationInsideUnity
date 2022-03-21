using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rotation
{
    public class RotateTowards : MonoBehaviour
    {
        public Transform target;
        public float speed = 20;
        public float step = 0;

        Vector3 direction;


        // Update is called once per frame
        void Update()
        {
            QuaternionRotateTowards();
            //Vector3RotateTowards();
        }

        void QuaternionRotateTowards()
        {
            step += speed * Time.deltaTime;
            direction = target.position - transform.position;

            //The difference between LookRotation and Euler is that
            //LookRotation take the up vector in consideration
            Quaternion directionAngles = Quaternion.LookRotation(direction);

            //Try with Euler.
            //Quaternion directionAngles = Quaternion.Euler(direction);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, directionAngles, step);
        }

        void Vector3RotateTowards()
        {
            step += speed * Time.deltaTime;
            direction = target.position - transform.position;

            Vector3 newDirection = Vector3.RotateTowards(transform.forward, direction, step, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}
