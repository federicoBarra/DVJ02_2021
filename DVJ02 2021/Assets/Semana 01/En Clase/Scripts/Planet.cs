using System;
using UnityEngine;

public class Planet : MonoBehaviour
{
    //void Awake()
    //{
    //    Debug.Log("Planet Awake");
    //}

    public float speed = 5;
    public float radius = 2;
    public float angle = 0;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Planet Started");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.right * speed * Time.deltaTime;

        Vector3 v3 = Vector3.zero;
        angle += speed * Time.deltaTime;
        //Math.cos

        v3.x = radius * Mathf.Cos(angle);
        v3.z = radius * Mathf.Sin(angle);

        transform.position = v3;

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
