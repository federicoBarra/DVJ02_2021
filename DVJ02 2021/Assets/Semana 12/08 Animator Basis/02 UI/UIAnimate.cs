using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana12
{
public class UIAnimate : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void AnimateUI()
    {
        animator.SetTrigger("Animate");
    }
}
}