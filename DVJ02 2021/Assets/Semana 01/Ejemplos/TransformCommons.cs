using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03
{
    public class TransformCommons : MonoBehaviour
    {
        //public MiScript ms;
        //public MiScript[] msArray;

        public Vector3 v3 = new Vector3(0, 0, 0);

        private void Start()
        {

	        //msArray = GetComponentsInChildren<MiScript>();

            //Vector3 v3 = new Vector3(0,0,0);

			Transform t = this.transform;

            Debug.Log(name + ": t.position: " + t.position);
            Debug.Log(name + ": t.localPosition: " + t.localPosition);

            Debug.Log(name + ": t.rotation: " + t.rotation);
            Debug.Log(name + ": t.localRotation: " + t.localRotation);

            Debug.Log(name + ": t.lossyScale: " + t.lossyScale);
            Debug.Log(name + ": t.localScale: " + t.localScale);

	        //ms.enabled = false;
	        //etc
        }

        void Update()
        {
            transform.position = v3;
        }

    }
}
