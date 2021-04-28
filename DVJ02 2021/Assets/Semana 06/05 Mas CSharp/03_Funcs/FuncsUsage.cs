using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana06
{
	public class FuncsUsage : MonoBehaviour
	{
	    //definicion básica de una Func
	    //public delegate V Func<T,U,V>(params T,U);
	    //!!! Una Func es un delegate ya predefinido usando Generics.
	    private Func<int, int, string> function;
		//private Func<int,>

	    private void Start()
	    {
	        function = FunctionTest;

	        Debug.Log(function(10,10));
	    }

	    private string FunctionTest(int x, int y)
	    {
	        return x+y.ToString();
	    }
	}
}