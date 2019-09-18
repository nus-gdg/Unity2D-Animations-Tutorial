using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Jump()
    {
    }

    public void Land()
    {
    }

    public void Move(float speed)
    {
    }

    public void SetCrouch(bool isCrouching)
    {
    }

    public void OnHurt()
    {
    }
}
