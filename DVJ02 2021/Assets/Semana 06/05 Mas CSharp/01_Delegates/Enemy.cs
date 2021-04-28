using System;
using UnityEngine;

namespace DVJ02.Semana06
{
public class Enemy : MonoBehaviour //celebrity
{
    public enum EnemyTypes
    {
        Flyer,
        Walker,
        Swimmer
    }

    private EnemyTypes enemyType;

    //Un delegate es basicamente un puntero a funcion.
    public delegate void EnemyKilledAction(Enemy enemy); //define el signature del delegate (delegate type)
    public EnemyKilledAction OnEnemyKilled; //(delegate instance)
	//public Action<Enemy> OnEnemyKilled; //(delegate instance)

	private void OnMouseDown()
    {
        EnemyDied();
    }

    void EnemyDied()
    {
	    if (OnEnemyKilled != null) // conocido como dispatch delegate.
		    OnEnemyKilled(this);

        //es lo mismo que

        if (OnEnemyKilled != null)
            OnEnemyKilled.Invoke(this);

        DieAsADispatcherAsStatic();
    }



	public static EnemyKilledAction OnEnemyKilledAsStatic; //(delegate instance)

        //OnEnemyKilledAsStatic -> EnemyManager.EnemyDiedMethod01, 
        //                         EnemyManager.EnemyDiedMethod02,
        //                         GameManager.SeMurioUnEnemigoChe,

    private void DieAsADispatcherAsStatic()
    {
        if (OnEnemyKilledAsStatic != null)
            OnEnemyKilledAsStatic(this);
    }

}
}
