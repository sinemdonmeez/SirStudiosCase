using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    /* ------------------------------------------ */
    public Transform Target;

    public Transform CamTransform;
    
    public Vector3 Offset;
    
    public float SmoothTime = 0.3f;

    /* ------------------------------------------ */

    private Vector3 velocity = Vector3.zero;

    /* ------------------------------------------ */

    private void Start()
    {
        CamTransform = this.gameObject.transform;
        Offset = CamTransform.position - Target.position;
    }

    private void LateUpdate()
    {
        // update position
        Vector3 targetPosition = Target.position + Offset;
        CamTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
    }

    /* ------------------------------------------ */
}
