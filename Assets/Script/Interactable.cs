using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject uIObject;
    // Start is called before the first frame update
    void Start()
    {
        uIObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "player")
        {
            uIObject.SetActive(true);
            
        }
    }
   
}
