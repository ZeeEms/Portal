using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInteract : MonoBehaviour
{
    public GameObject Object;
    public Transform PlayerTransform;
    public Camera Camera;

    
    public float range = 6f;
   
    public float ObjectDistance = 4f; 
   
    public float holdSmooth = 10f;
    

    
    void Update()
    {
       
        if (Input.GetKeyDown("e"))
        {
            Interact();
        }
        
        if (Input.GetKeyUp("e"))
        {
            letGo();
        }
       
        if (Object != null)
        {
            FollowCam();
        }
    }

    
    public void Interact()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, range))
        {
            
            if (hit.transform.CompareTag("Liftable"))
            {
                Object = hit.transform.gameObject;
                PickUp();
            }

            if (hit.transform.CompareTag("Cake"))
            {
                exitGame();
            }
        }
    }

    private void exitGame()
    {
        
        Application.Quit();
    }

    public void PickUp()
    {

        if (Object != null)
        {
            
            Object.transform.SetParent(PlayerTransform);

            // MAKE IT STAY STILL
            Rigidbody rb = Object.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true;  
            }
        }
    }
    public void letGo()
    {
        if (Object != null)
        {
            
            Object.transform.SetParent(null);

            // Make the physics come back by making it no kinematic
            Rigidbody rb = Object.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false; 
            }

            Object = null;
        }
    }
    public void FollowCam()
    {
        
        Vector3 targetPosition = Camera.transform.position + Camera.transform.forward * ObjectDistance;

        
        Object.transform.position = Vector3.Lerp(Object.transform.position, targetPosition, Time.deltaTime * holdSmooth);
        Object.transform.rotation = Quaternion.Lerp(Object.transform.rotation, Camera.transform.rotation, Time.deltaTime * holdSmooth);
    }
}

