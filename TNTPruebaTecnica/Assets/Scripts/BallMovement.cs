using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rigidBody;

    public Transform cam;
    public float ballForce = 250f;
    public bool collisionKick;
    public PlayerMovement1 activekick;


    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        collisionKick = false;
    }
    private void Update()
    {
        
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if(collisionKick)
        {
            collisionKick = false;
            Debug.Log("activa patada");
            if (other.CompareTag("feet"))
            {
                rigidBody.AddForce(cam.forward * ballForce);
                Debug.Log("Patea balon");

            }
            
        }
        else
        {
            rigidBody.AddForce(cam.forward * 20);
            collisionKick = false;
        }
        
    }

   
    public void touchKick()
    {  
            collisionKick = true;        
        
    }
}
