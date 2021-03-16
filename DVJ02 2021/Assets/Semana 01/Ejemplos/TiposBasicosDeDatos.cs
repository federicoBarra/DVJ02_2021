using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03
{
public class TiposBasicosDeDatos : MonoBehaviour
{
    //------------------------------------------------ Tipos abstractos
    public int entero;
    public float puntoFlotante;
    public bool booleano;
    public string texto;
    public Vector3 vector;
    //------------------------------------------------ Array
    public int[] arrayDeInts;
    //------------------------------------------------ List
    public List<int> intList;
    //------------------------------------------------ Enum
    public enum Enumerador
    {
        PrimerEnum,
        SegundoEnum
    }
    public Enumerador enumerado;
    //------------------------------------------------ Class
    [Serializable]
    public class ClaseBasica
    {
        public int a;
        public bool b;
    }
    public ClaseBasica ejemploClase;

    //------------------------------------------------ Method
    public static void Method01() { }
}
}