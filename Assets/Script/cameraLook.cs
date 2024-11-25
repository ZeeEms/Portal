using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLook : MonoBehaviour
{
    public Transform Player;
    public Transform Bot;

    private void Update()
    {
        Bot.transform.LookAt(new Vector3(Player.position.x, transform.position.y, Player.position.z));
    }

    
}
