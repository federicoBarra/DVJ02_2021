using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.TPS
{
    public class Pine : MonoBehaviour
    {

        public float localRotX;
        public float localRotY;
        public float localRotZ;

        public Vector3 up;

        public Material common;
        public Material dropped;
        private Renderer rend;
	    public Vector3 cross;

	    public Transform pineUp;
	    public Transform worldUp;
	    public Transform pineUpWorldUpCross;

	    public float distance = 3;

		private void Start()
        {
            rend = GetComponent<Renderer>();
        }

        private void Update()
        {
			//SOLUCION FORMA 01
            localRotX = (transform.localEulerAngles.x + 360)%360; // (270 + 360) % 360 = 270
            localRotY = (transform.localEulerAngles.y + 360)%360; // (-60 + 360) & 360 = 300
            localRotZ = (transform.localEulerAngles.z + 360)%360;

            bool drop = false;

			if ((localRotZ > 60 && localRotZ < 330) || (localRotX > 60 && localRotX < 330))
                drop = true;

            if (drop)
                rend.sharedMaterial = dropped;
            else
                rend.sharedMaterial = common;

	        //SOLUCION FORMA 02
			up = transform.up;
	        pineUp.transform.position = transform.position + up * distance;
	        worldUp.transform.position = Vector3.up * distance;
			cross = Vector3.Cross(transform.up, Vector3.up);
	        pineUpWorldUpCross.transform.position = transform.position + cross * distance;

			//if (Mathf.Abs(cross.x) + Mathf.Abs(cross.z) > ciertoValor)
			// pino caido
		}

		//SOLUCION FORMA 03
		private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Pine Triggered with: " + other.name);
        }
    }

}