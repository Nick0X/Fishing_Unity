using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class begat : MonoBehaviour
{

    public Animator Animator;


void Update()
{
      
      if(Input.anyKey)
       {Animator.SetTrigger("Run");
        Animator.Play("RunForward");
       }
      //else Animator.SetTrigger("Stay");
      
}

}
