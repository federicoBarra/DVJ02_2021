using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Transform : MonoBehaviour
//{

//}

public class Ship : MonoBehaviour
{
    [Header("Cosas del script")]
    public float speed;
    [Header("Referencias")]
    public List<Transform> planetas;
    [Header("Data")]
    public float speedData;

    [System.NonSerialized]
    public float datoLoco;
    [HideInInspector]
    public float datoLoco02;

    //[MyAtributoLoco]
    public float datoLoco03;

    [Header("DEBUG")]
    public int planetsCount;

    //public int planetsCount;
    //public int planetsCount;
    //public int planetsCount;

    void Start()
    {
        foreach (Transform planeta in planetas)
        {
            Debug.Log("nombre: " + planeta.gameObject.name);
        }

        Debug.Log(transform);
        Debug.Log(gameObject);
        //Debug.Log(transform.gameObject.transform.gameObject.transform.transform);

        Debug.Log("");
        Debug.LogWarning("");
        Debug.LogError("");

    }

    private bool alive = true;
    private bool isPlayerControlled = true;

    public float tiempo;

    void Update()
    {
        if (!alive)
            return;

        if (isPlayerControlled)
            return;

        planetsCount = planetas.Count;
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(hor, 0, ver);


        transform.position += direccion * speed * Time.deltaTime;

        tiempo += Time.deltaTime;
        float val = Mathf.Sin(tiempo);
        FindObjectOfType<Light>().intensity = 1 + val * 2;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Debug.Break();
            Debug.Log("REcien aprete: ");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Estoy aprentando: ");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("solte la tecla: ");
        }

        //Debug.Log("horizontal: " + hor);
    }


    void Die()
    {
        if (!alive)
            return;

        alive = false;

        //cambia material a nave destroy
        //Destro
    }

}
