using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana01
{
    public class ControlStatements : MonoBehaviour, EjemploInterface
    {
        public List<string> stringList;// = new List<string>();
        public int[] arrayDeInts;// = { 0, 6, 10 };
        void Start()
        {
            //int[] arrayDeInts = { 0, 6, 10 };
            string[] arrayDeStrings = { "Pepe", "Tito", "Batman" };

            List<int> intList = new List<int>();

            // intList.Count = 0
            intList.Add(0);
            intList.Add(6);
            intList.Add(10);

            //intList.Add();
            intList.Insert(1,3);

            intList.Remove(6);
            // intList.Count = 3
            intList.RemoveAt(1);

            // intList.Count = 2

            stringList.Remove("");
            stringList.RemoveAt(0);

            if (stringList != null)
            {
                for (int i = 0; i < stringList.Count; i++)
                {
                    Debug.Log("string list val: " + stringList[i]);
                }
            }

            for (int i = 0; i < intList.Count; i++)
            {
                Debug.Log("int list val: " + i);
            }


            int a = 0;

            foreach (int pepe in arrayDeInts)
            {
                Debug.Log(pepe);
                // arrayDeInt = arrayDeInts[i]
            }

            arrayDeStrings = new[] {"MArte", "tierra", "venus", "Pluton"};
            arrayDeStrings = new[] { "MArte", "tierra", "venus", "Pluton", "Zarlanga" };

            //arrayDeStrings = new string[10];
            //
            //arrayDeStrings = null;

            //0
            //6
            //10

            for (int i = 0; i < arrayDeInts.Length; i++)
            {
                int pepe;
                pepe = arrayDeInts[i];
                Debug.Log(pepe);
            }

            while (false)
            {
            }

            if (a == 0)
            {
            }
            else if (a == 1)
            {
            }
            else
            {
            }

            switch (a)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }

        }

        void Update()
        {
            stringList.Add("asdasd");
        }

        public void InterfaceMethod01()
        {
            //throw new System.NotImplementedException();
        }

        public void InterfaceMethod02(int intParam)
        {
            //throw new System.NotImplementedException();
        }
    }

}