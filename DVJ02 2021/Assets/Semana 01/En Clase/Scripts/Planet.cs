using System;
using DVJ02.Semana02;
using UnityEngine;

namespace DVJ02.Semana01
{
    public class Planet : MonoBehaviour
    {
        [Serializable]
        public class PlanetData
        {
            public float traslationRadius;
            public float traslationSpeed;

            public Vector3 rotationAxis;
            public float rotationSpeed;

            public float size = 1;

            public Material mat;
            public bool hasAtmosphere;
            public Material atmosphereMat;
        }

        //void Awake()
        //{
        //    Debug.Log("Planet Awake");
        //}

        public float speed = 5;
        public float radius = 2;
        public float angle = 0;

        public float rotationAngle = 0;

        public Vector3 wantedScale;

        public float rotationSpeed = 5;

        public Vector3 rotationDirection;

        public GameObject atmosfera;
        public GameObject luna;

        //public void Init(float radius,float speed,float size,...etc )
        public void Init(PlanetData pd)
        {
            radius = pd.traslationRadius;
            speed = pd.traslationSpeed;
            rotationDirection = pd.rotationAxis;
            rotationSpeed = pd.rotationSpeed;
            wantedScale = Vector3.one * pd.size;
            atmosfera.SetActive(pd.hasAtmosphere);
            enabled = true;
            atmosfera.GetComponent<MeshRenderer>().material = pd.atmosphereMat;
            GetComponent<MeshRenderer>().material = pd.mat;
        }

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Planet Started");

            foreach (Transform child in transform)
            {
                Debug.Log("child name: " + child.name);
            }

            MeshRenderer unoSolo = GetComponentInChildren<MeshRenderer>();

            MeshRenderer[] todos = GetComponentsInChildren<MeshRenderer>();

            //GameObject go = GameObject.Find("Luna"); ESTO NO

            //atmosfera = transform.GetChild(0).gameObject;
        }

        // Update is called once per frame
        void Update()
        {
            //transform.position += Vector3.right * speed * Time.deltaTime;

            Vector3 v3 = Vector3.zero;
            angle += speed * Time.deltaTime;
            //Math.cos
            //0 - 360
            //0 - 2pi (3.14)
            v3.x = radius * Mathf.Cos(angle);
            v3.z = radius * Mathf.Sin(angle);

            transform.position = v3;
            
            //transform.rotation = Quaternion.Euler(0, rotationAngle, 0); // (x,y,z,w) = 0.1,0.2,0.6,0.1

            transform.localScale = wantedScale;

            transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
            //transform.Rotate()

            //Debug.Log("Rotation en x: " + transform.rotation.x);
            //MAthf.Cos()
            //MAthf.Sin()

            //Ecuación paramétrica círculo
            //x = r cos t;
            //z = r sin t;
            //Centro en punto (a,b) con un radio r

            //Debug.Log("Planet Update: " + Time.deltaTime);
        }

        void OnDisable()
        {
            Debug.Log("Planet Disabled");
        }

        void OnEnable()
        {
            Debug.Log("Planet Enabled");
        }
    }
}