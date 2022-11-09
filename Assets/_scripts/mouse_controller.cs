using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class mouse_controller : MonoBehaviour
{
    Animator anim;
    private NavMeshAgent nav;
    [SerializeField] private static float speed = 10.0f;
    private bool hasReachedDestination()
          {
             if (nav.remainingDistance == 0f)
                return true;
             else
                 return false;
           }    
    void Start()
    {
       anim = GetComponent<Animator>();
       nav = GetComponent<NavMeshAgent>();
       nav.speed = speed;
    }

    void FixedUpdate()
    {
        
       if(Input.GetMouseButtonDown(0)) 
        {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

            if(Physics.Raycast (ray, out hit, 5000) && Input.GetMouseButtonDown(0))
            {
            nav.SetDestination(hit.point);            
            }
        }
        bool check = hasReachedDestination();
            if (check == false) anim.SetBool("walk", true);
            else anim.SetBool("walk", false);
    }
}