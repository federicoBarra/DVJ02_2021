using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
	public float cadaCuantoCambioDePlaneta = 5;
	public float timer;

	public List<GameObject> planetas = new List<GameObject>();

	// indice de planeta actual
	private int planetaActual = 0;
	public Vector3 offset;
	public float camVelocity = 1;

	private Vector3 lastCamPos;

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
			lastCamPos = transform.position;
		}

		Vector3 newPos = planetas[planetaActual].transform.position + offset;

		//timer/cadaCuantoCambioDePlaneta
		//0.5f/5 = 0.10f
		//1/5 = 0.20f
		//4/5 = 0.80f

		//transform.position = Vector3.Lerp(lastCamPos, newPos, timer/cadaCuantoCambioDePlaneta); //timer > 1
		//camVelocity * Time.deltaTime = 0.5
		//transform.position = Vector3.Lerp(lastCamPos, newPos, 0.5f); //1
		transform.position = Vector3.Lerp(transform.position, newPos, camVelocity * Time.deltaTime); //2
		
	}
}
