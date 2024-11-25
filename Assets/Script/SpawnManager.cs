using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Portal;
    public GameObject Portal2;
    public Camera Cam;
  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnPortals(Portal);

        }
        if (Input.GetMouseButtonDown(1))
        {
            SpawnPortals(Portal2);
        }
    }

    void SpawnPortals(GameObject portals)
    {
        RaycastHit hit;

        if (Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit))
        {
            
            Vector3 hitPos = hit.point;
            portals.transform.position = hitPos;
            Vector3 normal = hit.normal;
            portals.transform.right = normal;

        }
    }
}
