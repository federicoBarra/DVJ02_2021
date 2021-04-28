using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana06
{
	public class ObserverPattern : MonoBehaviour
	{
		public class Observer //fan
		{
			public virtual void Notify(Subject s, string notification)
			{
				//Pasó tal cosa en el Subject
			}
		}

		public class Subject //celebrity
		{
			private List<Observer> observers;

			public void RegisterObserver(Observer o)
			{
				observers.Add(o);
			}

			public void Notify(string notification) //lanzo un tweet
			{
				foreach (Observer o in observers)
				{
					o.Notify(this, notification);
				}
			}
		}

	    void Start()
	    {
            Subject quentinTarantino = new Subject();

            Observer tito = new Observer();
            Observer pepe = new Observer();

	        quentinTarantino.RegisterObserver(tito);
	        quentinTarantino.RegisterObserver(pepe);

            quentinTarantino.Notify("Gané un Oscar, Soy groso");
        }
	}
}