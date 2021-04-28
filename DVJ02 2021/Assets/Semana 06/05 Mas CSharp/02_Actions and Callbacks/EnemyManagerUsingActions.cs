using System;
using UnityEngine;

namespace DVJ02.Semana06
{
public class EnemyManagerUsingActions : MonoBehaviour
{
    public GameObject enemyPrefab;

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject go = Instantiate(enemyPrefab, new Vector3(i * 2 - 10, 1, 0), Quaternion.identity);
            EnemyUsingActions e = go.GetComponent<EnemyUsingActions>();

            // as a callback
            e.SetCallback(EnemyDiedAsACallback);
        }
    }

    private void EnemyDiedAsACallback(EnemyUsingActions e)
    {
        Debug.Log("Using Callbacks. Enemy has died " + e.name);
        //tell game.
    }
}
}