using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterAnimator : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Jump()
    {
        animator.SetBool("IsJumping", true);
    }

    public void Land()
    {
        animator.SetBool("IsJumping", false);
    }

    public void Move(float speed)
    {
        animator.SetFloat("Speed", speed);
    }

    public void SetCrouch(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
}
