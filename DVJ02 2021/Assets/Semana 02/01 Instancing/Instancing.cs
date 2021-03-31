using System;
using System.Collections.Generic;
using DVJ02.Semana01;
using UnityEngine;

namespace DVJ02.Semana02
{
    public class Instancing : MonoBehaviour
    {
	    public Planet planetPrefab; //Transform

        public List<Planet.PlanetData> planetsData;

	    public List<Planet> generatedPlanets = new List<Planet>();

	    private float time = 0;

		private void Start()
        {
			for (int i = 0; i < planetsData.Count; i++)
			{
			    Planet.PlanetData pd = planetsData[i];

                GameObject gameObjectQueRecienInstancie = Instantiate(planetPrefab).gameObject;

			    gameObjectQueRecienInstancie.AddComponent<TiposBasicosDeDatos>();

	            Planet p = gameObjectQueRecienInstancie.GetComponent<Planet>();
                p.Init(pd);

                generatedPlanets.Add(p);

                Debug.Log("padre del planeta recien instanciado: " + gameObjectQueRecienInstancie.transform.parent);

			    gameObjectQueRecienInstancie.transform.parent = FindObjectOfType<Camera>().transform;

			    //go.transform.parent = gameObject.transform;
			}
            //if is dead and far away from player
            //Destroy(gameObject, 1);
        }
        
        //public List<Material> planetMaterials;

        //private void Start()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        float distanceToCenter = i * 2.0F;
        //
        //        GameObject go = Instantiate(planetPrefab, new Vector3(distanceToCenter, 0, 0), Quaternion.identity).gameObject;
        //
        //        //go.AddComponent<Planeta>();
        //
        //        Planet p = go.GetComponent<Planet>();
        //
        //        p.radius = distanceToCenter;
        //
        //        int validIndex = i % planetMaterials.Count; //mod
        //
        //        // i = 0 -> 0
        //        // i = 1 -> 1
        //        // i = 2 -> 2
        //        // i = 3 -> 0
        //
        //        go.GetComponent<MeshRenderer>().material = planetMaterials[validIndex];
        //
        //        //p.Initialize(gameObject.transform, i * 3, 654);
        //        //p.radius = i * 3;
        //        //p.sun = gameObject.transform;
        //
        //        generatedPlanets.Add(p);
        //    }
        //}


        //despues de cierto tiempo
        //for de instanciacion de enemigos.

        //void Update()
        //{
        //    Mathf.Lerp(0, 10, 0); // = 0
        //    Mathf.Lerp(0, 10, 0.5f); // = 5
        //    Mathf.Lerp(0, 10, 1); // = 10
        //
        //    Debug.Log("Valor de lerp: " + Mathf.Lerp(0, 10, time)); // = 10
        //
        //    time += Time.deltaTime;
        //}

    }
}
//public class Instancing : MonoBehaviour
//{
//    public Camera2 cam;
//
//    public Transform objetoAMover;
//
//    public Transform prefab;
//
//    public Planet planetPrefab; //Transform
//
//    public List<Material> planetMaterials;
//    public Material[] planetMaterialsAsArray;
//
//    public Dictionary<string, int> radioPorPlaneta;
//
//    public List<Planet> generatedPlanets = new List<Planet>();
//
//    private float time = 0;
//
//    private void Start()
//    {
//        radioPorPlaneta.Add("Tierra", 987123876);
//        radioPorPlaneta.Add("Marte", 987123876);
//
//        Debug.Log(radioPorPlaneta["Marte"]);
//        //planetMaterialsAsArray.Length
//        //Random.Range(0,2f)
//        for (int i = 0; i < 10; i++)
//        {
//            GameObject go = Instantiate(planetPrefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity).gameObject;
//
//            //go.AddComponent<Planeta>();
//
//            Planet p = go.GetComponent<Planet>();
//
//            int validIndex = i % planetMaterials.Count;
//            go.GetComponent<MeshRenderer>().material = planetMaterials[validIndex];
//
//            //p.Initialize(gameObject.transform, i * 3, 654);
//            //p.radius = i * 3;
//            //p.sun = gameObject.transform;
//
//            generatedPlanets.Add(p);
//            cam.planetas.Add(go);
//        }
//    }
//
//    public Vector3 desde;
//    public Vector3 hasta;
//
//    void Update()
//    {
//        Mathf.Lerp(0, 10, 0); // = 0
//        Mathf.Lerp(0, 10, 0.5f); // = 5
//        Mathf.Lerp(0, 10, 1); // = 10
//
//        Debug.Log("Valor de lerp: " + Mathf.Lerp(0, 10, time)); // = 10
//
//        time += Time.deltaTime;
//
//        objetoAMover.transform.position = Vector3.Lerp(desde, hasta, time);
//    }
//
//}