using UnityEngine;

namespace DVJ02.Semana04
{
	public class MouseInputExample : MonoBehaviour
	{
		private Camera cam;

		public GameObject objetoAInstanciar;

		void Start()
		{
			cam = Camera.main;
		}

	    private void Update()
	    {
	        float x = Input.GetAxis("Mouse X");
	        float y = Input.GetAxis("Mouse Y");

	        //Debug.Log("Axis (x|y) = ( " + x + " | " + y + " )");

	        Vector3 mousePos = Input.mousePosition;

	        //Debug.Log("Position (x|y) = ( " + mousePos.x + " | " + mousePos.y + " )");

	        Ray ray = cam.ScreenPointToRay(mousePos);
	        Debug.DrawRay(ray.origin, ray.direction * 50, Color.yellow);

		    //Physics.Raycast(ray.origin, ray.direction)

			if (Input.GetMouseButtonDown(0))
		    {
			    RaycastHit hit;
			    if (Physics.Raycast(ray, out hit, 200))
			    {
				    Instantiate(objetoAInstanciar, hit.point, Quaternion.identity);
				}
			    Debug.Log("Left Click");
			    //Instantiate(objetoAInstanciar);
		    }

		    if (Input.GetMouseButtonDown(1))
		    {
			    Debug.Log("Right Click");
		    }

			transform.LookAt(objetoAInstanciar.transform);
		}
	}
}

