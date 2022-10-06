using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Actions : MonoBehaviour
{
    private Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Stay()
    {
        animator.SetFloat("Speed", 0f);
    }

    public void Walk()
    {
        animator.SetFloat("Speed", 0.5f);
    }
    public void Run()
    {
        animator.SetFloat("Speed", 2f) ;
    }
}
   
