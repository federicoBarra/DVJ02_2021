using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana13
{
	public class StanleyController02 : EntityBase
	{
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.E))
				Punch();
		}

		//[Header("Stanley")]
		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (!(state == EntityState.Idle || state == EntityState.Moving))
				return;

			float horizontal = Input.GetAxis("Horizontal");
			float vertical = Input.GetAxis("Vertical");

			Vector2 move = Vector2.zero;
			move.x = horizontal;
			move.y = vertical;

			move.Normalize();

			movement = move;
		}
	}
}
