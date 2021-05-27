using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana09
{
	public class CSGenerics : MonoBehaviour
	{
		public List<int> pepe;
	    public List<string> pepeStrings;

        private void Start()
	    {
	        GenericMethod<int>(0);
	        GenericMethod<string>("string");
	        //SomeManager.Get().SomeMethod();
	    }

	    private void Update()
	    {
            //if (enemyCount <=0)
                //opendoor
	    }

	    private void GenericMethod<T>(T index)
	    {
	        T something = index;
	        Debug.Log(something);
	    }
	}
}