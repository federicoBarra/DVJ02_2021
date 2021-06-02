using System;
using UnityEngine;

namespace DVJ02.Semana11
{
    public class CSAnonymMethods : MonoBehaviour
    {
        public Action variasAcciones;
        public Action metodoAnonimo;

        private void Start()
        {
            metodoAnonimo = MetodoLoco;

            metodoAnonimo = delegate
            {
                Debug.Log("Metodo Anónimo");
                Debug.Log("Pepe");
            }; //anonymous method or inline code

            variasAcciones += metodoAnonimo;

            //XXX Estoy pisando la funcion anterior.
            metodoAnonimo = () => { Debug.Log("Metodo Anónimo 02"); };  //lambda expression

            variasAcciones += metodoAnonimo;

            if (variasAcciones != null)
                variasAcciones();


            Action<int> sendToLog = (param) => { Debug.Log("param: " + param); };
            //Es lo mismo que
            //UnityAction<int> sendToLog = delegate(int param) { Debug.Log("param: " + param); };

            sendToLog(5);
        }

        void MetodoLoco()
        {
            Debug.Log("Metodo Anónimo");
            Debug.Log("Pepe");
        }
        void Metodo2(int param)
        {
            Debug.Log("param: " + param);
        }
    }
}