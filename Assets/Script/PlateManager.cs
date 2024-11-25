using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateManager : MonoBehaviour
{
    public GameObject door;
    public GameObject button;
    bool isOpen = false;
    

    private void OnTriggerEnter(Collider col)
    {
        if (!isOpen)
        {
            door.transform.rotation = Quaternion.Euler(-90, 90, 0);
            button.transform.position += new Vector3(0, -0.27f, 0);
            isOpen = true;
            Debug.Log("isOpen");
        }
        

    }

    private void OnTriggerExit(Collider other)
    {
        if (isOpen) {
            door.transform.rotation = Quaternion.Euler(-90, 0, 0);
            button.transform.position += new Vector3(0, 0.27f, 0);
            isOpen = false;
            Debug.Log("isClosed");
        }
        
    }
}
