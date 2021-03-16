using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03
{
public class ControlStatements : MonoBehaviour, EjemploInterface
{
	void Start () 
    {
        int[] arrayDeInts = { 0, 0, 0};
        List<int> intList = new List<int>();

	    int a = 0;

        foreach (int arrayDeInt in arrayDeInts)
        {
        }

        for (int i = 0; i < arrayDeInts.Length; i++)
        {
        }

        while (false)
        {
        }

	    if (a == 0)
	    {
	    }
        else if (a == 1)
        {
        }
        else
        {
        }

	    switch (a)
	    {
            case 0:
	            break;
            case 1:
                break;
            case 2:
                break;
        }

	}

    public void InterfaceMethod01()
    {
        //throw new System.NotImplementedException();
    }

    public void InterfaceMethod02(int intParam)
    {
        //throw new System.NotImplementedException();
    }
}

}