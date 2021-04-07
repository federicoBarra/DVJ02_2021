using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DVJ02.Semana03
{
    public class UIBasisExample : MonoBehaviour
    {
        public Text textObject;
        public TMP_Text textObjectTMP;

        public int numero = 500000;
	    public int numero02;

		// Use this for initialization
		private void Start()
        {
	        Text[] texts = FindObjectsOfType<Text>();

            //textObject.transform

            textObject.text = numero.ToString();

            textObjectTMP.text = "Este es de text mesh pro";

            Debug.Log("Hola que tal: " + numero);
        }

        public void ButtonPressed()
        {
            Debug.Log("Button pressed");
        }

    }

}