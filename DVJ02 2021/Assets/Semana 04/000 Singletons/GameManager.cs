using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DVJ02.Semana04
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        int Score;

        //public static GameManager Instance
        //{
        //    get { return instance; }
        //    private set { instance = value; }
        //}

        private static GameManager instance;
        public static GameManager Get()
        {
            return instance;
        }
        private void Awake()
        {
            Debug.Log("Awake de " + name);

	        if (instance != null)
	        {
	            //Debug.Log("Ya existe una instancia de GameManager, que es " + instance.name);
	            //Debug.Log("Como ya existe una, destrui esta: " + name);
                Destroy(gameObject);
		        //return;
	        }
	        else
	        {
                //Debug.Log("Esta es la primera instancia de GameManager: " + name);
			    instance = this;
                //Debug.Log("La guardo");
                DontDestroyOnLoad(gameObject);
	        }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
	            //OnNewGameButtonPressed();
				UniverseCreator.Get().CreateUniverse();
	            //OnNewGameButtonPressed();
				//......
			}
        }

        public void AddScore(int score)
        {
            Score += score;
        }

	    public void OnNewGameButtonPressed()
	    {
			SceneManager.LoadScene("SceneManagementExample 02");
	    }

    }
}