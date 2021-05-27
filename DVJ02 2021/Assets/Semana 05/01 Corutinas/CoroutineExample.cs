using System.Collections;
using DVJ02.Semana05;
using UnityEditor;
using UnityEngine;

namespace DVJ02.Semana05
{
    //https://docs.unity3d.com/Manual/Coroutines.html
    public class CoroutineExample : MonoBehaviour
    {
        public Transform target;
        public string nombreDeMetodo = "";

        //Renderer[] rends = GetComponentsInChildren<Renderer>();

        void Start()
        {
            Debug.Log("Start");

            gameObject.SetActive(false);

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

        [Header("DEBUG")]
        public Color debugSphereColor;
        public float debugSphereSize;
        void OnDrawGizmos()
        {
            // Draw a yellow sphere at the transform's position
            Gizmos.color = debugSphereColor;
            Gizmos.DrawSphere(transform.position, debugSphereSize);

            //si mi nivel es de 5x5, no puede haber mas de 5 bombas-> bombCount = 5;
            if (debugSphereSize > 4)
                debugSphereSize = 4;

            //Gizmos.draw
        }
    }
}

[CustomEditor(typeof(CoroutineExample))]
public class LookAtPointEditor : Editor
{
    public override void OnInspectorGUI()
    {
        CoroutineExample targetCo = (CoroutineExample)target;

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Editor Loco", "Algo");
        if (GUILayout.Button("Achicar esfera"))
        {
            targetCo.debugSphereSize -= 1;
        }

        if (GUILayout.Button("Agrandar esfera"))
        {
            targetCo.debugSphereSize += 1;
        }
        EditorGUILayout.EndHorizontal();

        DrawDefaultInspector();
    }
}
