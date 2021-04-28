using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana06
{
	public class StupidPlayer : MonoBehaviour
	{
	    public delegate void StupidPlayerAction(float enrageVal);
	    public static event Action<float> OnPlayerDidSomethingStupid;
	    //Los events son similares a los delegates normales solo que estan pensados para manejar mas 
	    // dinámicamente al agregado y removido de métodos. Internamente funcionan como un List al
	    // hacerles += y -=. A diferencia de los delegates normales que se vuelve a instanciar el delegate entero.
	    // Además los events no pueden ser igualados a algo. 
	    //En la práctica suele ser más usado el event que el delegate a secas.

	    private void Update()
	    {
	        if (Input.GetKeyDown(KeyCode.Space))
	        {
	            DoSomethingStupid();
	        }
	    }

	    void DoSomethingStupid()
	    {
	        if (OnPlayerDidSomethingStupid != null)
	        {
	            float amountOfStupidity = 1;
	            OnPlayerDidSomethingStupid(amountOfStupidity);
	        }
	    }
	}
}
