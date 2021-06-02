using System;
using System.Collections.Generic;

namespace DVJ02.Semana11
{
    [Serializable]
	public class PlayerStats // Model
	{
		public int life;

	    public int Strenght = 10;
	    public int Dexterity = 10;
	    public int Magic = 10;
	    public int Luck = 10;

		public static event Action<PlayerStats> OnPlayerDied;

	    public List<ItemData> items;

	    public void AddToAllStats()
	    {
	        Strenght++;
	        Dexterity++;
	        Magic++;
	        Luck++;
	    }

		public void DealDamage(int damage)
		{
			life -= damage;
			if (life < 0)
			{
				if (OnPlayerDied != null)
					OnPlayerDied(this);
			}
		}
	}
}