using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    public float cadaCuantoCambioDePlaneta = 5;
	public float timer;

    public AnimationCurve linear;
    public AnimationCurve spherical;


    public List<GameObject> planetas = new List<GameObject>();

	// indice de planeta actual
	private int planetaActual = 0;
	public Vector3 offset;
	public float camVelocity = 1;

	//private Vector3 lastCamPos;

	void LateUpdate()
	{
		if (planetas.Count <= 0)
			return;

		timer += Time.deltaTime;

		if (timer > cadaCuantoCambioDePlaneta)
		{
			planetaActual++;
			planetaActual = planetaActual % planetas.Count;
			timer = 0;
			//lastCamPos = transform.position;
		}

		Vector3 newPos = planetas[planetaActual].transform.position + offset;

        //timer/cadaCuantoCambioDePlaneta
        //0.5f/5 = 0.10f
        //1/5 = 0.20f
        //4/5 = 0.80f

        //transform.position = Vector3.Lerp(lastCamPos, newPos, timer/cadaCuantoCambioDePlaneta); //timer > 1
        //camVelocity * Time.deltaTime = 0.5
        //transform.position = Vector3.Lerp(lastCamPos, newPos, 0.5f); //1
	    //transform.position = newPos;

        //Debug.Log("camVelocity * Time.deltaTime: " + (camVelocity * Time.deltaTime)); // 

        transform.position = Vector3.Lerp(transform.position, newPos, camVelocity * Time.deltaTime); //t=~ 0.02
	}
}
/*
 *    private float cantidadDeVidas;

    ESTO 
    public float CantidadDeVidas
    {
        get
        {
            return cantidadDeVidas;
        }
        private set
        {
            if (value >= 0)
                cantidadDeVidas = value;
            else
                cantidadDeVidas = 0;
        }
    
    }

    ES LO MISMO QUE ESTO

    public float GetCantidadDeVidas()
    {
        return cantidadDeVidas; 
    }
    void SetCantidadDeVidas(float x)
    {
        if (x >= 0)
            cantidadDeVidas = x;
        else
            cantidadDeVidas = 0;
    }

    void Died()
    {
        //CantidadDeVidas = -1;
        SetCantidadDeVidas(-1);
    }
 *
 */

// coupling, loose, tight
//public interface IHittable
//{
//    void ReceiveDamage(float damageAmount);
//}