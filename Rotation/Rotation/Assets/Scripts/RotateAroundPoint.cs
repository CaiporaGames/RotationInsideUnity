using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rotation
{
    public class RotateAroundPoint : MonoBehaviour
    {
        public Transform sun;
        public float speed = 20;
        public float angle = 20;

        // Update is called once per frame
        void Update()
        {
            //This uses Eule angle to rotate around a point. If the obj stay still it 
            // has the facing behaviour. This is good for camera rotation
            //transform.RotateAround(sun.position, Vector3.up, Time.deltaTime * speed);


            //It can rotate around self. This is the same as: transform.Rotate();
            //transform.RotateAround(transform.position, Vector3.up, Time.deltaTime * speed);









            //Imagine the object position as a vector on Unity space.
            //This rotate the vector by 30 degrees in y axis
            //Quaternion orbit;
            //orbit = Quaternion.Euler(new Vector3(0, 30, 0));
            //Debug.Log(orbit);
            //transform.rotation = orbit;

            //Imagine the object position as a vector on Unity space.
            //This rotate the vector by 30 degrees in y axis constinuasly.
            //In this form it works like transform.Rotate but much more cumbersome
            //Quaternion orbit;
            //orbit = Quaternion.Euler(new Vector3(0, 30, 0) * Time.deltaTime * speed)
            //    * transform.rotation;
            //transform.rotation = orbit;

            //Let use it to rotate around a point without making it to face the object.
            //We have more control over the obj self rotation.
            Vector3 orbit = Vector3.forward * 4;
           
            orbit = Quaternion.Euler(new Vector3(0, angle, 0)) * orbit;
            angle += speed * Time.deltaTime;
            if (angle > 360)
            {
                angle -= 360;
            }
            transform.position = sun.position + orbit;






            // ### Slerp x Lerp Section ###
            //Rotate an vector A to match the angle of other vector B.
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, sun.rotation, angle);
            //angle = speed * Time.deltaTime;

            //angle += Time.deltaTime;

            //transform.rotation = Quaternion.Lerp(transform.rotation, sun.rotation, angle);


            //transform.rotation = Quaternion.Slerp(transform.rotation, sun.rotation, angle/60);
        }
    }
}
