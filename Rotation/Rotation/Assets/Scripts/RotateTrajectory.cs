using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rotation
{
    public class RotateTrajectory : MonoBehaviour
    {
        public Transform sun;
        public float speed = 20;
        public float angle = 20;
        Vector3 trajectory;


        Vector3 orbit;
        private void Start()
        {
            trajectory = transform.position - sun.position;
            orbit = trajectory;
        }

        // Update is called once per frame
        void Update()
        {
            RotateLookRotation();
            //Testing();
        }

        void RotateLookRotation()
        {
            Vector3 orbit = Vector3.forward * 4;
            Debug.Log("Before: " + orbit);

            //This is the second function of the Quaternion.Euler when multiplied by a vector3 it rotate this vector. 
            //The order matters here.
            orbit = Quaternion.Euler(new Vector3(0, angle, 0)) * orbit;
            Debug.Log("Later: " + orbit);

            orbit = Quaternion.LookRotation(trajectory) * orbit;

            angle += speed * Time.deltaTime;
            if (angle > 360)
            {
                angle -= 360;
            }
            transform.position = sun.position + orbit;
        }

        //This was a try to make the same computation as the LookRotation function but with Euler function
        void Testing()
        {
            orbit = Quaternion.Euler(trajectory * angle) * trajectory;

            angle += speed * Time.deltaTime;

            transform.position = sun.position + orbit;
        }
    }
}
