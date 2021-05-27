using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana10
{
    public class UIButtonClickExample : MonoBehaviour
    {
        void Start()
        {
            bool valorEncontrado = false;

            List<int> valoresPosibles = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            do
            {
                int rnd = Random.Range(0, valoresPosibles.Count); //10%

                if (rnd == 5)
                    valorEncontrado = true;

                valoresPosibles.RemoveAt(rnd);

            } while (!valorEncontrado);
        }

        public void OnClick(int val)
        {
            Debug.Log(val);
        }
    }
}