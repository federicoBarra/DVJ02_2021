using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("nombre: " + name);
        Debug.Log("posicion de mundo: " + transform.position);
        Debug.Log("posicion con respecto al padre: " + transform.localPosition);
    }
}
