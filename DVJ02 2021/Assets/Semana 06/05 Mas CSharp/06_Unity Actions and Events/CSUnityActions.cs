using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DVJ02.Semana06
{
public class CSUnityActions : MonoBehaviour
{
    public UnityEvent eventos;
    //https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html
    public UnityAction variasAcciones;
    
    private void Start()
    {
        eventos.AddListener(ListenerPorCodigo); //guarda que no aparece en el inspector cuando lo agregamos por codigo aaaaaaaa

        //cuidado con RemoveAllListeners que solo removerá las acciones agregadas por código.
        //eventos.RemoveAllListeners();

        //variasAcciones += Action01;
        //variasAcciones += Action02;

        Invoke("InvokeRepeated", 1);
    }

    void InvokeRepeated()
    {
		eventos.Invoke();
        //if (variasAcciones != null)
        //    variasAcciones();
    }


    public void ListenerPorEditor()
    {
        Debug.Log("ListenerPorEditor");
    }

    public void ListenerPorCodigo()
    {
        Debug.Log("ListenerPorCodigo");
    }


    public void Action01()
    {
        Debug.Log("Action01");
    }

    public void Action02()
    {
        Debug.Log("Action02");
    }
}
}