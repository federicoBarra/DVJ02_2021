using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana03
{
    public class EjemploTags : MonoBehaviour
    {
        //Edit->Proyect Setting->Physics 

        //Tags are useful for triggers in Collider control scripts; they need to work out whether the player is interacting with an enemy, a prop, or a collectable, for example.

        //Layers are most commonly used by Cameras to render only a part of the scene, and by Lights to illuminate only parts of the scene. But they can also be used by raycasting to selectively ignore colliders or to create collisions.
        private void Start()
        {
            GameObject[] bolas = GameObject.FindGameObjectsWithTag("Bola"); //NO LLAMAR ESTO NUNCA DESDE UN Update()

            foreach (GameObject bola in bolas)
            {
                Debug.Log("Bola name: " + bola);
            }
        }

    }
}