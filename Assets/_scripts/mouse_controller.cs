using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class mouse_controller : MonoBehaviour
{
    //Animator anim;
    private NavMeshAgent nav;
    public float speed;
    public CharacterController controller;
    private Vector3 position;
        
    void Start()
    {
       position = transform.position;
       
       //anim = GetComponent<Animator>();
       nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
        locatePosition();
        }
            moveToPosition();
            //if (hasReachedDestination() == true) anim.SetBool("walk", false);
           // else anim.SetBool("walk", true);
    }
    
    void locatePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if(Physics.Raycast(ray, out hit, 1000))
            {
            position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            Debug.Log("Position: " + position);          
            }
    }
    
    void moveToPosition()
    {
        if(Vector3.Distance(transform.position, position)>1)
        {
        Quaternion newRotation = Quaternion.LookRotation(position-transform.position, Vector3.forward);
        newRotation.x = 0f;
        newRotation.z = 0f;
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 10);
        controller.SimpleMove(transform.forward * speed);
        }
    }

    /*public bool hasReachedDestination()
    {
    return nav.remainingDistance == 0f;

    }*/
}