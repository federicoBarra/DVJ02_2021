using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana02
{
    public class CollidersExample : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            //collision.

            //Early exit
            if (collision.gameObject.name == "Cube")
		        return;

            if (collision.gameObject.tag == "Bola")
                return;

            //if (collision.gameObject.name == "Sphere")
            //    return;

            Debug.Log(name + " OnCollisionEnter " + collision.gameObject.name);
			Destroy(collision.gameObject);

            //if (collision.gameObject.name != "Cube" && collision.gameObject.name != "Sphere")
            //{
            //    Debug.Log(name + " OnCollisionEnter " + collision.gameObject.name);
            //    Destroy(collision.gameObject);
            //}
        }

        private void OnCollisionExit(Collision collisionInfo)
        {
            Debug.Log(name + " OnCollisionExit " + collisionInfo.gameObject.name);
        }

        private void OnCollisionStay(Collision collisionInfo)
        {
            Debug.Log(name + " OnCollisionStay " + collisionInfo.gameObject.name);
        }
    }
}


// clase FisicaMagicaDeUnity
// void Update()
//{
//      if (collisionaron 2 objetos)
//      {
//          Collision collision = new Collition(data del choque)
//          objectoQueColisiono01.OnCollisionEnter(collision);
//          objectoQueColisiono02.OnCollisionEnter(collision);
//      }
//}