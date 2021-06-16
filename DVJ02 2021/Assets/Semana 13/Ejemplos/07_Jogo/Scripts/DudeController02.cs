using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DVJ02.Semana13
{
	public class DudeController02 : EntityBase
	{
		[Header("Dude")] public Transform target;
		public float waitTime = 3;
		public float distanceToStopFromPlayer = 1;

		protected override void FixedUpdate()
		{
			base.FixedUpdate();

			switch (state)
			{
				case EntityState.Idle:
					t -= Time.deltaTime;
					if (t <= 0)
						state = EntityState.Moving;
					break;

				case EntityState.Moving:
					Vector2 dir = target.position - transform.position;
					dir.Normalize();
					movement = dir;
					if (Vector2.Distance(transform.position, target.position) < distanceToStopFromPlayer)
						Wait();
					break;
			}
		}

		void Wait()
		{
			state = EntityState.Idle;
			t = waitTime;
			movement = Vector2.zero;
		}

	}
}