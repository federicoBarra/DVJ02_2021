using System.Collections;
using System.Collections.Generic;
using DVJ02.Semana06;
using UnityEngine;

public class OperatorOverloading : MonoBehaviour
{
    public class CuboLoco
    {
        public float metrosCuadrados = 2;

        public static CuboLoco operator +(CuboLoco b, CuboLoco c)
        {
            CuboLoco cl = new CuboLoco();
            float result = b.metrosCuadrados + c.metrosCuadrados;
            cl.metrosCuadrados = result;
            return cl;
        }

        //public static CuboLoco operator +=(CuboLoco b)
        //{
        //    CuboLoco cl = new CuboLoco();
        //    float result = b.metrosCuadrados + c.metrosCuadrados;
        //    cl.metrosCuadrados = result;
        //    return cl;
        //}
    }


    void Awake()
    {
        CuboLoco cl01 = new CuboLoco();
        cl01.metrosCuadrados = 2;

        CuboLoco cl02 = new CuboLoco();
        cl02.metrosCuadrados = 3;

        //cl01 += cl02;

        Debug.Log("resultado final " + (cl01 + cl02).metrosCuadrados);
    }
}



public class AchievementSystem
{

    void Awake()
    {
        Enemy.OnEnemyKilledAsStatic += SeMurioUnEnemigoChe;
    }

    void SeMurioUnEnemigoChe(Enemy e)
    {
        //chequear si complete el achievement de matar 100 enemigos.
    }

}