using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Teleporting : MonoBehaviour
{
  [SerializeField] private GameObject TeleportPosition;
  [SerializeField] private GameObject Fisher;
  [SerializeField] private GameObject TeleportButtonToSpot1;
  Animator anim;
  //public No_Movement script;
           
 void Start() 
  {
    Fisher = GameObject.Find("Fisher");
    TeleportPosition = GameObject.Find("Teleport_Spot_1");
    TeleportButtonToSpot1 = GameObject.Find("TeleportButtonToSpot1");
    TeleportButtonToSpot1.SetActive(false);
    anim = gameObject.GetComponent<Animator>();
   }
    void Update()
    {
      float distance = Vector3.Distance(Fisher.transform.position, TeleportPosition.transform.position);
      if(distance<=20f) 
      {
        TeleportButtonToSpot1.SetActive(true);
      }
      else TeleportButtonToSpot1.SetActive(false);
    }
 public void Teleport() 
  {
    Fisher.transform.position = TeleportPosition.transform.position;
    GetComponent<mouse_controller>().enabled = false;
    GetComponent<interacting>().enabled = false;
    GetComponent<FisherController>().enabled = true;
    GetComponent<DrawProj>().enabled = true;
    anim.SetBool("walk", false);
  }          
}
