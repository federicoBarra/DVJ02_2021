using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana03
{
    public class LayeredCollition : MonoBehaviour // Script asignado en el plano
    {
        public LayerMask layerMask; //Esto es una mascara bitwise basicamente.
        //https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm

        public int checkAgainstLayer;

        // Use this for initialization
        private void Start()
        {
            checkAgainstLayer = LayerMask.NameToLayer("Esferas01");
        }

        private void OnCollisionEnter(Collision esferaQueChoco)
        {
            string layerName = LayerMask.LayerToName(esferaQueChoco.gameObject.layer);

            LayerMask conjuntoDeLayersConLasQueQuieroMostrarOtraCosa = layerMask;

            bool contiene = Contains(conjuntoDeLayersConLasQueQuieroMostrarOtraCosa, esferaQueChoco.gameObject.layer);
            if (contiene)
            {
                Debug.Log("Colisiono con una layer contenida en layerMask (GameObject: " + esferaQueChoco.gameObject.name + ")");
            }
            else
            {
                Debug.Log("Colisiono con una layer NO contenida en layerMask (GameObject: " + esferaQueChoco.gameObject.name + ")");
            }

            Debug.Log("Colisiono con la layer: " + layerName + " del GameObject: " + esferaQueChoco.gameObject.name + ")");
        }

        public bool Contains(LayerMask mask, int layer)
        {
            return mask == (mask | (1 << layer));
        }

        //11111111111111

        //layer = 8
        //

        //00000010000000 (1 << layer)
        //|
        //00000000000001 mask
        //=
        //00000010000001  -> chequear este resultado con mask




    }
}
