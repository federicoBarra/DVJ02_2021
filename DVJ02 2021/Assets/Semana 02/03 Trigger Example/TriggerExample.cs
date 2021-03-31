using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana02
{
    public class TriggerExample : MonoBehaviour //ESTA en la sphere
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "LightSwitchTrigger")
                //prende la luz, capo
                ;

            Debug.Log(name + " OnTriggerEnter " + other.gameObject.name);
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log(name + " OnTriggerExit " + other.gameObject.name);
        }

        private void OnTriggerStay(Collider other)
        {
            //Debug.Log(name + " OnTriggerStay " + other.gameObject.name);
        }
    }
}
