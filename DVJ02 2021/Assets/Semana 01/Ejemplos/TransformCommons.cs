using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03
{
    public class TransformCommons : MonoBehaviour
    {
	    //public MiScript ms;
	    //public MiScript[] msArray;

		private void Start()
        {

	        //msArray = GetComponentsInChildren<MiScript>();

			Transform t = this.transform;

            Debug.Log("transform.position: " + transform.position);
            Debug.Log("transform.localPosition: " + transform.localPosition);

            Debug.Log("transform.rotation: " + transform.rotation);
            Debug.Log("transform.localRotation: " + transform.localRotation);

            Debug.Log("transform.lossyScale: " + transform.lossyScale);
            Debug.Log("transform.localScale: " + transform.localScale);

	        //ms.enabled = false;
	        //etc
        }
    }
}
