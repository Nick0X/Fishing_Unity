using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisherController : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float BlastPower = 5;

    public GameObject Floatball;
    public Transform ShotPoint;

    
    private void Update()
    {
        float HorizontalRotation = Input.GetAxis("Horizontal");
        float VericalRotation = Input.GetAxis("Vertical");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + 
            new Vector3(0, HorizontalRotation * rotationSpeed, VericalRotation * rotationSpeed));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject CreatedFloatball = Instantiate(Floatball, ShotPoint.position, ShotPoint.rotation);
            CreatedFloatball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;
            
            
        }
    }


}
