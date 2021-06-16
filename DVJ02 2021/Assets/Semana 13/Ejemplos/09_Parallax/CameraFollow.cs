using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana13
{
	public class CameraFollow : MonoBehaviour
	{
		public Transform target;
		public Vector3 distance;
		public float camSpeed = 10;

		//public AnimationCurve bulletTime;
		private void LateUpdate()
		{
			transform.position = Vector3.Slerp(transform.position, target.position + distance, camSpeed * Time.deltaTime);

		    //Time.deltaTime;
		    //Time.fixedDeltaTime;
		}


	    void Udapte()
	    {
            //if (justo presiono jump)
	        //    m_Rigidbody.AddForce(transform.up * m_Thrust * Time.deltaTime);
        }
	}
}
