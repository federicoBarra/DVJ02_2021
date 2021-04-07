using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DVJ02.Semana03
{
    public class SceneManagementExample : MonoBehaviour
    {
	    public Text buttonText;

        public void LoadScene()
        {
            //La escena necesita estar agregada a las Build Settings
            SceneManager.LoadScene("SceneManagementExample 02");

            //Batman b = new Batman();
            //b.

        }
    }


    public partial class Batman
    {
        public void Die()
        {

        }
    }


    



}
