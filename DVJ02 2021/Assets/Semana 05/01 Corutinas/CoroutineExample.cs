using System.Collections;
using UnityEngine;

namespace DVJ02.Semana05
{
    //https://docs.unity3d.com/Manual/Coroutines.html
    public class CoroutineExample : MonoBehaviour
    {
        public Transform target;
        public string nombreDeMetodo = "";
        void Start()
        {
            StartCoroutine("WaitAndPrint");//evitar usar
                                           //StartCoroutine(nombreDeMetodo);

            // o
            StartCoroutine(WaitAndPrint(10));
            //Coroutine c = StartCoroutine(WaitAndPrint(10));

            //StopCoroutine(c);

            StopCoroutine(WaitAndPrint());

            //StopAllCoroutines();
            //Fade();

            //Pepe();

            StartCoroutine(Fade());
            //Coroutine c01 = StartCoroutine(Fade());
        }

        void Update()
        {
            //if (pegue)
            //StartCoroutine(PrenderFuegoLaEspadaPorXSegundos(2));
        }

        IEnumerator WaitAndPrint()
        {
            yield return new WaitForSeconds(5);
            print("WaitAndPrint " + Time.time);
        }

        IEnumerator WaitAndPrint(int waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);
        }


        void Died()
        {
            //Destroy(gameObject, 10);
            StartCoroutine(DestroyAfterTime(10));
        }

        IEnumerator DestroyAfterTime(float t)
        {
            yield return new WaitForSeconds(t);
            Destroy(gameObject);
        }

        void Pepe()
        {
            Debug.Log(Time.time);
            Debug.Log(Time.time);
            float t = 1;
            while (t > 0)
            {
                t -= Time.deltaTime;
                Debug.Log("t: " + t);
            }
        }

        IEnumerator Fade()
        {
            Debug.Log(Time.time);
            //yield return null;
            Debug.Log(Time.time);

            yield return new WaitForSeconds(1);
            //waitfor
            //Vector3 initialPos = transform.position;

            float t = 1;
            Material mat = target.GetComponent<MeshRenderer>().material;
            Color c = mat.color;

            while (t > 0)
            {
                t -= Time.deltaTime;
                Debug.Log("t: " + t);
                c.a = t;
                mat.color = c;// que pasa si yo comento esta linea???
                yield return null;
                //yield return new WaitForResourceLoad(nombreDelRecurso);
            }
        }
    }
}