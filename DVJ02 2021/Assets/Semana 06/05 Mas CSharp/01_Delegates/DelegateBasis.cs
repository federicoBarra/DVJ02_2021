using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana06
{
	public class DelegateBasis : MonoBehaviour
	{
	    //Un delegate es basicamente un puntero a funcion.
	    public delegate void PunteroAFuncion(string s); //define el signature del delegate (delegate type)
	    
	    private void Start()
	    {
		    PrintPropio("Tito");

		    PunteroAFuncion punteroALog; //(delegate instance)

		    //punteroALog("");

			punteroALog = Debug.Log;
	        punteroALog("Mostrando puntero a funcion Debug.Log() ");
			// sería
		    //Debug.Log("Mostrando puntero a funcion Debug.Log() ");

			punteroALog = PrintPropio;
		    punteroALog("Mostrando puntero a PrintPropio() ");

            //punteroALog = PrintTextoDefault;
            // sería
            //PrintPropio("Mostrando puntero a PrintPropio() ");
	    }

		void PrintPropio(string s)
	    {
	        Debug.Log(s + "\n");
	    }

		void PrintTextoDefault()
		{
			Debug.Log("texto default" + "\n");
		}

	    int MoverAutoYQueExplote(GameObject auto, float explotionRadius, int etc)
	    {
	        return 0;
	    }

	}

    public class Player
    {
        private float poisonDamage;

        void ApplyPoison(Enemy01 enemy)
        {
            enemy.ApplyPoison();
            enemy.OnDie = EnemyDied;
        }

        void EnemyDied()
        {
            Debug.Log("Se murió el enemigo");
        }

    }

    public class Enemy01
    {
        public delegate void OnDieDelegate();

        public OnDieDelegate OnDie;

        void Update()
        {
            //procesar poison hasta que se muera
            Die();
        }

        public void ApplyPoison()
        {

        }

        void Die()
        {
            OnDie();
        }

    }
}
