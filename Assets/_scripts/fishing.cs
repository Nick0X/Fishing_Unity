using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishing : MonoBehaviour
{
    Animator anim;
    public bool fishing_start;
     void Start() 
        {
            anim = gameObject.GetComponent<Animator>();
            fishing_start = false;
        }
    void FishStart()
    {
        
    }
    void Update() 
    {
        if(Input.GetKey(KeyCode.E)) fishing_start = true;
        else fishing_start = false;
        if(fishing_start == false) anim.SetBool("punch", false);
        if(fishing_start == true) anim.SetBool("punch", true);
    }
    
}
