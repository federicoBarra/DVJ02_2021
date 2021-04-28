using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana06
{
public class EnemyManager : MonoBehaviour //fan
{
    public GameObject enemyPrefab;
    private List<Enemy> enemies = new List<Enemy>();

    private int enemyCount;

    // Use this for initialization
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject go = Instantiate(enemyPrefab, new Vector3(i*2 - 10, 1, 0), Quaternion.identity);
            Enemy e = go.GetComponent<Enemy>();

            // as a dispatcher.
            e.OnEnemyKilled += EnemyDiedMethod01; 
            //e.OnEnemyKilled.addMethod(EnemyDiedMethod01)
            e.OnEnemyKilled += EnemyDiedMethod02;
            enemies.Add(e);
            //e.OnEnemyKilled -= EnemyDiedMethod01;
        }

        Enemy.OnEnemyKilledAsStatic += EnemyDiedMethod01;
        Enemy.OnEnemyKilledAsStatic += EnemyDiedMethod02;

            //enemyCount = 10;
            //UseDelegateAsStatic();
    }

    private void EnemyDiedMethod01(Enemy e)
    {
        enemyCount--;
        Debug.Log("EnemyDiedMethod01 " + e.name);
    }

    private void EnemyDiedMethod02(Enemy e)
    {
        Debug.Log("EnemyDiedMethod02 " + e.name);
    }








    void UseDelegateAsStatic()
    {
        Enemy.OnEnemyKilledAsStatic += EnemyDiedMethod01;
        Enemy.OnEnemyKilledAsStatic += EnemyDiedMethod02;
    }


    void OnDestroy()
    {
        //for (int i = 0; i < 10; i++)
        //{
        //    Enemy e = enemies[i];
        //
        //    e.OnEnemyKilled -= EnemyDiedMethod01;
        //    e.OnEnemyKilled -= EnemyDiedMethod02;
        //}

        Enemy.OnEnemyKilledAsStatic -= EnemyDiedMethod01;
        Enemy.OnEnemyKilledAsStatic -= EnemyDiedMethod02;
    }
}
}