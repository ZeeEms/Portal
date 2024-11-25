using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(LineRenderer))]
public class Lazeer : MonoBehaviour
{

    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private float laserDistance = 20f;
    [SerializeField] private LayerMask ignoreMask;
    [SerializeField] private UnityEvent OnHitTarget;

    private RaycastHit rayHit;
    private Ray ray;

    private void Awake()
    {
        lineRenderer.positionCount = 2;
    }

    private void Update()
    {
        ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out rayHit))
        {
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, rayHit.point);

            
            if (rayHit.collider.TryGetComponent(out target target))
            {
                target.Hit();
                
            }
            
        }
        else
        {
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, transform.position + transform.forward * laserDistance);
            
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(ray.origin, ray.direction * laserDistance);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(rayHit.point, 0.23f);
    }
}
