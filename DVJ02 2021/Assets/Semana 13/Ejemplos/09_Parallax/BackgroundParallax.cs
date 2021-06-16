using UnityEngine;

namespace DVJ02.Semana13
{
	public class BackgroundParallax : MonoBehaviour
	{
		[System.Serializable]
		public class ParallaxLayer
		{
			public GameObject layer;
			public float moveCameraRatio = 0;
			public float moveCameraRatioY = 0;
		}

		public ParallaxLayer[] layers;

		float lastCamXPos;
	    private Camera cam;

	    void Start()
	    {
	        cam = Camera.main;
        }

		void LateUpdate()
		{
			float mainCamPos = cam.transform.position.x;
			float deltaCamX = lastCamXPos - mainCamPos;

			foreach (ParallaxLayer layer in layers)
			{
				layer.layer.transform.position += Vector3.right * deltaCamX * layer.moveCameraRatio;
				layer.layer.transform.position += Vector3.up * deltaCamX * layer.moveCameraRatioY;
			}

			lastCamXPos = mainCamPos;
		}
	}
}