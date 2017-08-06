using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowComponent : MonoBehaviour
{
    #region Property
    [Header("References: ")]
    [SerializeField] protected GameObject target;

    [Header("Values: ")]
    [SerializeField] protected Vector3 distanceToTarget;
    [SerializeField] protected float lerpIntensity = 0.125f;

    [Header("Options: ")]
    [SerializeField] protected bool lockOnTarget = false;
    #endregion  

    #region Methods
    public virtual void ChangeCameraOffset(Vector3 newOffset, bool lockOn = false)
    {
        distanceToTarget = newOffset;
        lockOnTarget = lockOn;
    }
    protected virtual void FollowTarget()
    {
        if(target)
        {
            transform.position = Vector3.Lerp(transform.position, target.transform.position + distanceToTarget, lerpIntensity);

            if (lockOnTarget) transform.LookAt(target.transform);
        }
    }
    #endregion

    #region Unity_Callback
    protected void Update()
    {
        FollowTarget();
    }
    #endregion
}
