using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DVJ02.Semana03
{
    public class GameManager : MonoBehaviour
    {
        public int Score;

        private static GameManager instance;
        public static GameManager Get()
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
			DontDestroyOnLoad(gameObject);
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