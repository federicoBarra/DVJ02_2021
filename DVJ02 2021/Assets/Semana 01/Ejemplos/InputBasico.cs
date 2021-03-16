using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03
{
public class InputBasico : MonoBehaviour
{
	public enum miEnum
	{
		Keycode_Alpha01 = 49,
		Keycode_Alpha02 = 50,
	}

	public List<KeyCode> keycodes = new List<KeyCode>()
	{
		KeyCode.Alpha1,
		KeyCode.Alpha2,
		KeyCode.Alpha3
	};
    private void Update()
    {
	    int valorInicial = (int) KeyCode.Alpha1;

		//KeyCode key = (KeyCode)50;


	    //for (int i = 0; i < planetCount; i++)
	    //{
		//	KeyCode key = (KeyCode)(valorInicial + i);
		//    if (Input.GetKeyDown(key))
		//    {
		//
		//    }
		//}

        if (Input.GetKeyDown(KeyCode.Alpha1))
            Debug.Log("Alpha1 presionado");
	    //if (Input.GetKeyDown(KeyCode.Alpha1))
		//    Debug.Log("Alpha1 presionado");
	    //if (Input.GetKeyDown(KeyCode.Alpha1))
		//    Debug.Log("Alpha1 presionado");
	    //if (Input.GetKeyDown(KeyCode.Alpha1))
		//    Debug.Log("Alpha1 presionado");
	    //if (Input.GetKeyDown(KeyCode.Alpha1))
		//    Debug.Log("Alpha1 presionado");
	    //if (Input.GetKeyDown(KeyCode.Alpha1))
		//    Debug.Log("Alpha1 presionado");
	    //if (Input.GetKeyDown(KeyCode.Alpha1))
		//    Debug.Log("Alpha1 presionado");

		float horizontal = Input.GetAxis("Horizontal"); // [-1, 1]
        float vertical = Input.GetAxis("Vertical");

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Barra espaciadora soltada");
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Valor Horizontal al mantener A: " + horizontal);
            Debug.Log("Valor Vertical al mantener A: " + vertical);
        }
    }
}
}
