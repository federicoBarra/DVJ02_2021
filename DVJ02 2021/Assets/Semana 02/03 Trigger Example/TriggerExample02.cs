using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana02
{
    public class TriggerExample02 : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(name + " OnTriggerEnter 02 " + other.gameObject.name);
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log(name + " OnTriggerExit 02 " + other.gameObject.name);
        }
    }
}