using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana11
{
    public class PlayerController : MonoBehaviour //Controller
	{
	    public PlayerStats stats;

		void Start()
		{
			PlayerStats.OnPlayerDied += PlayerDied;

		    string data = JsonUtility.ToJson(stats);

            Debug.Log(data);
        }

	    // Update is called once per frame
	    private void Update()
	    {
	        if (Input.GetKeyDown(KeyCode.Space))
	            LevelUp();
	        //setposition
	    }

	    private void LevelUp()
	    {
	        stats.AddToAllStats();
	    }

		void PlayerDied(PlayerStats ps)
		{
			//hacer algo.
		}

		//OnColitioEnter(...)
		//{
		//	
		//}
	}
}