using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana10
{
	public class UIFaceCamera : MonoBehaviour
	{
		public Camera cam;
		// Use this for initialization
		private void Start()
		{
			cam = Camera.main;
		}

		// Update is called once per frame
		private void Update()
		{
			transform.LookAt(transform.position + cam.transform.forward, cam.transform.up);
		}
	}
}
