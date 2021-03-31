using System;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana01
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

    //public float Prop;
    public float Prop { get; set; }

    //PascalCase -> Metodos, properties, events
    //camelCase -> variables de clase
    //_camelCase -> parametros de metodo

    void addValue(int value)
    {

    }

    void ChangeSomething(int _entero)
    {
        Debug.Log(_entero);
        Debug.Log(entero);
        entero = _entero;
    }



    //------------------------------------------------ Method
    public static void Method01() { }
}
}