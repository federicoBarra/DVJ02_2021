using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana06
{
	public class Agro : MonoBehaviour //Enemy
	{
	    public Gradient agroGradient;
	    Material enemyMaterial;
	    public float enrageDuration = 2;
	    private float enrageT;

	    private void Start()
	    {
	        StupidPlayer.OnPlayerDidSomethingStupid += Enrage;
	        enemyMaterial = GetComponent<Renderer>().material;
	    }

	    private void Update()
	    {
	        if (enrageT <= 0)
	            return;

	        float gradValue = enrageT/enrageDuration;

	        enemyMaterial.color = agroGradient.Evaluate(gradValue);

	        enrageT -= Time.deltaTime;
	    }
	    public void Enrage(float percent)
	    {
	        float rage = UnityEngine.Random.Range(percent/2, percent);
	        enrageT = enrageDuration * rage;
	    }

	    public void OnDestroy()
	    {
	        StupidPlayer.OnPlayerDidSomethingStupid -= Enrage;
	    }
	}
}