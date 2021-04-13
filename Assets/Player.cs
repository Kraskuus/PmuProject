using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private bool isHopping;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
     
   private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && !isHopping)
        {
            animator.SetTrigger("hop");
            isHopping = true;
        }
    }

    public void FinishHop()
    {
        isHopping = false;
    }
}
