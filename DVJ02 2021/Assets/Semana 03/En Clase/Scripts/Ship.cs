using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;


namespace DVJ02.Semana03
{
	public class Ship : MonoBehaviour
	{
		public float speed = 1;
		public float rotationSpeed = 1;

		void Update()
		{
			float hor = Input.GetAxis("Horizontal"); //0.0000000000001 [-1,1] //0  ~0
			float ver = Input.GetAxis("Vertical");

			Vector3 movement = new Vector3(hor, 0, ver) * speed;
			transform.position += movement * Time.deltaTime;

			Vector3 lastPosition = transform.position;
            
			Vector3 wantedPosition = transform.position + movement * Time.deltaTime;
            
			float anguloReal = RealAngle(lastPosition, wantedPosition);
		    resultRealAngle = anguloReal;
            
            Quaternion currentRotation = transform.rotation;
			Quaternion newRotation = Quaternion.Euler(0, anguloReal, 0);
			Quaternion finalRotation = Quaternion.Slerp(currentRotation, newRotation, rotationSpeed * Time.deltaTime);
            
		    if (Mathf.Abs(hor) > 0.001f || Mathf.Abs(ver) > 0.001f)
                transform.rotation = finalRotation;
		}

        [Header("Debug")]
	    public float resultAngle;
	    public float resultRealAngle;

        float RealAngle(Vector3 from, Vector3 to)
		{
			Vector3 right = Vector3.right;
            
            Vector3 vectorDireccion = to - from;

			float angle = Vector3.Angle(right, vectorDireccion);

		    //return angle;

		    resultAngle = angle;
            //Debug.Log(angle);

			Vector3 cross = Vector3.Cross(right, vectorDireccion);

			if (cross.y < 0)
			{
				angle = 360 - angle;
			}

			return angle;
		}
	}
}