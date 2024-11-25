using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDamage : MonoBehaviour
{
    public float threshold;

    private void FixedUpdate()
    {
        //Player pos may not be under threshold if it it then it responds
        if (transform.position.y < threshold)
        {
            //spawn point
            transform.position = new Vector3(54.41f, 2.72f, -16.67f);
        }
    }
}
