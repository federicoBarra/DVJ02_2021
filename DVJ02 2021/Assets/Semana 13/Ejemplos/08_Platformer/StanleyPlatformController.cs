using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana13
{
	public class StanleyPlatformController : MonoBehaviour
	{
		public Transform groundPosition;
		public Transform groundPosition02;
		public bool grounded;
		protected Rigidbody2D rig;
		protected Animator animator;

		public float jumpHeight;
		public float gravity = -20;
		protected Vector2 movement;
		public float moveSpeed;

		public float t;
		public float punchTime = 0.4f;
		public float damageTime = 0.5f;

		readonly Vector3 faceingRight = new Vector3(2, 2, 2);
		readonly Vector3 faceingLeft = new Vector3(-2, 2, 2);
		public LayerMask collitionLayers;

		// Use this for initialization
		void Start()
		{
			rig = GetComponent<Rigidbody2D>();
			animator = GetComponent<Animator>();
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
			{
				Jump();
			}
		}

		// Update is called once per frame
		void FixedUpdate()
		{
			Application.targetFrameRate = fps;

			float horizontal = Input.GetAxis("Horizontal");
			movement.x = horizontal;

			Vector2 newVelocity = Vector2.zero;
			newVelocity.x = movement.x * moveSpeed;

			if (movement.y <= 0)
				CheckGroundedState();

			if (!grounded)
				movement.y += gravity * Time.deltaTime;
			else
				movement.y = 0;
			newVelocity.y = movement.y;

			rig.velocity = newVelocity;
			animator.SetFloat("Speed", movement.magnitude);
			//handle sprite flip
			if (movement.x > 0)
				transform.localScale = faceingRight;
			if (movement.x < 0)
				transform.localScale = faceingLeft;
		}

		public int fps = 200;
		void Jump()
		{
			if (!grounded)
				return;
			grounded = false;
			movement.y = Mathf.Sqrt(2f * jumpHeight * -gravity);
		}

		void CheckGroundedState()
		{
			RaycastHit2D hit = Physics2D.Raycast(groundPosition.position, -Vector2.up, 0.05f, collitionLayers);
			RaycastHit2D hit02 = Physics2D.Raycast(groundPosition02.position, -Vector2.up, 0.05f, collitionLayers);
			if (hit.collider != null || hit02.collider != null)
				grounded = true;
			else
				grounded = false;
		}
	}
}