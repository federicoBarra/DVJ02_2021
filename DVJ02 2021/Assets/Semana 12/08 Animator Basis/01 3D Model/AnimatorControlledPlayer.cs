using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana12
{
	public class AnimatorControlledPlayer : MonoBehaviour
	{
	    private Animator animator;
	    // Use this for initialization
	    private void Start()
	    {
	        animator = GetComponent<Animator>();
	    }

	    // Update is called once per frame
	    private void Update()
	    {
	        float horizontal = Input.GetAxis("Horizontal");

	        animator.SetFloat("Speed", Mathf.Abs(horizontal));

	        if (Input.GetKeyDown(KeyCode.Space))
	            animator.SetTrigger("Attack");
	    }

		public void AttackMoment(string val)
		{
			Debug.Log("val: " + val);
		}
	}
}
