using UnityEngine;


namespace DVJ02.Semana13
{
	public class EntityBase : MonoBehaviour
	{
		[Header("Entity")] public Transform puchTrigger;

		public float collitionRadius = 0.2f;
		protected Rigidbody2D rig;
		protected Animator animator;

		protected Vector2 movement;
		public float moveSpeed;

		protected float t;
		public float punchTime = 0.4f;
		public float damageTime = 0.5f;

		readonly Vector3 faceingRight = new Vector3(1, 1, 1);
		readonly Vector3 faceingLeft = new Vector3(-1, 1, 1);
		SpriteRenderer renderer;

		public enum EntityState
		{
			Idle,
			Moving,
			Punching,
			TakingDamage,
		}

		public EntityState state = EntityState.Idle;

		// Use this for initialization
		void Start()
		{
			rig = GetComponent<Rigidbody2D>();
			animator = GetComponent<Animator>();
			renderer = GetComponent<SpriteRenderer>();
		}

		// Update is called once per frame
		protected virtual void FixedUpdate()
		{
			renderer.sortingOrder = -(int)(transform.position.y*100f);
			switch (state)
			{
				case EntityState.Idle:
				case EntityState.Moving:
					rig.velocity = movement * moveSpeed;
					animator.SetFloat("Speed", movement.magnitude);
					//handle sprite flip
					if (movement.x > 0)
						transform.localScale = faceingRight;
					if (movement.x < 0)
						transform.localScale = faceingLeft;
					break;
				case EntityState.Punching:
					movement = Vector2.zero;
					t -= Time.deltaTime;
					if (t <= 0)
						state = EntityState.Idle;
					break;
				case EntityState.TakingDamage:
					movement = Vector2.zero;
					t -= Time.deltaTime;
					if (t <= 0)
						state = EntityState.Idle;
					break;
			}
		}

		protected void Punch()
		{
			state = EntityState.Punching;
			t = punchTime;
			animator.SetTrigger("Punch");

			Collider2D[] colliders = Physics2D.OverlapCircleAll(puchTrigger.position, collitionRadius);
			if (colliders.Length > 0)
			{
				for (int i = 0; i < colliders.Length; i++)
				{
					Collider2D col = colliders[i];
					if (col.tag == "Damageable")
					{
						EntityBase eb = col.GetComponentInParent<EntityBase>(); // XXX QUE HAY DE MALO CON ESTE APPROACH?
						if (eb)
							eb.TakeDamage();
					}
				}
			}
		}

		protected void TakeDamage()
		{
			state = EntityState.TakingDamage;
			t = damageTime;
			animator.SetTrigger("Hitted");
		}

		void OnDrawGizmos()
		{
			// Draw a yellow sphere at the transform's position
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(puchTrigger.position, collitionRadius);
		}
	}
}
