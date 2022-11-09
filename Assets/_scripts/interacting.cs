using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacting : MonoBehaviour
{
   Animator anim;
   public bool walking;
   bool punch;
        void Start()
        {
            anim = gameObject.GetComponent<Animator>();
            walking = false;
            punch = false;
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.E)) punch = true;
            else punch = false;
            if(punch == false) anim.SetBool("punch", false);
            if(punch == true) anim.SetBool("punch", true);
        } 
}