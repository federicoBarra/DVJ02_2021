using UnityEngine;

namespace DVJ02.Semana04
{
    public class UniverseCreator : MonoBehaviour
    {
        public GameObject planetPrefab;

        public float minPlanetSize;
        public float maxPlanetSize;

        public float minPlanetDistanceToSun;
        public float maxPlanetDistanceToSun;

        public int minPlanetsToCreate;
        public int maxPlanetsToCreate;

        public GameObject Sun;

        private static UniverseCreator instance = null;
        public static UniverseCreator Get()
        {
            return instance;
        }
        private void Awake()
        {
	        if (instance != null)
	        {
				Destroy(gameObject);
		        return;
	        }
            instance = this;
        }

        public void CreateUniverse()
        {
            int planetCount = Random.Range(minPlanetsToCreate, maxPlanetsToCreate);

            for (int i = 0; i < planetCount; i++)
            {
                GameObject newPlanetGO = Instantiate(planetPrefab);
                Planet newPlanet = newPlanetGO.GetComponent<Planet>();

                float distanceToSun = Random.Range(minPlanetDistanceToSun, maxPlanetDistanceToSun);

                float planetSize = Random.Range(minPlanetSize, maxPlanetSize);

                newPlanet.Set(Sun, distanceToSun, planetSize);
                newPlanet.traslationSpeed = Random.Range(5f, 20f);
                newPlanet.transform.parent = transform;
            }
        }

        public void PlanetClicked(Planet planet)
        {
            Destroy(planet.gameObject);
            GameManager.Get().AddScore(10);
        }

    }
}