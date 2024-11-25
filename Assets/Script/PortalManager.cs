using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public Transform Portalpos;
    public Transform Portalpos2;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Portal")) {
            CharacterController cc = GetComponent<CharacterController>();

            cc.enabled = false;
            transform.position = Portalpos2.transform.position;
            transform.rotation = new Quaternion(transform.rotation.x, Portalpos2.rotation.y, transform.rotation.z, transform.rotation.w);

            cc.enabled = true;
        }

        if (col.CompareTag("Portal2"))
        {
            CharacterController cc = GetComponent<CharacterController>();

            cc.enabled = false;
            transform.position = Portalpos.transform.position;
            transform.rotation = new Quaternion(transform.rotation.x, Portalpos.rotation.y, transform.rotation.z, transform.rotation.w);

            cc.enabled = true;
        }
    }
    
}
