using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rotation
{
    public class RotateAroundSelf : MonoBehaviour
    {
        public float speed = 20;
        public float angle = 30;


        // Update is called once per frame
        void Update()
        {
            //Wrong way. transform.rotation is a quarternion
            //transform.rotation += new Vector3(0, 1, 0) * Time.deltaTime * speed;












            ///Quaternion.Euler(); transform a Vector3 in an angle.

            //transform.rotation = Quaternion.Euler(new Vector3(0, 30, 0) * Time.deltaTime * speed);
            //Debug.Log(transform.rotation);

            //Rotate the transform in 30 degrees once. It not cotinuos to adding angles
            //transform.rotation = Quaternion.Euler(new Vector3(0, 30, 0));
            //Debug.Log(transform.rotation);


            //Right way. This is in Euler angle
            //transform.eulerAngles += new Vector3(0, 1, 0) * Time.deltaTime * speed;

            //Rotate around y axis. Uses Euler angle. 
            //transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speed);










            //Rotate around y axis. Uses Euler angle. Not smooth. Not because frames
            //transform.Rotate(new Vector3(0, 1, 0), angle);
            //transform.Rotate(new Vector3(0, 1, 0), angle * Time.deltaTime * speed);

            //Vector3.RotateTowards();
        }
    }
}
