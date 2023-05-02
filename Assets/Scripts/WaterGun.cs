using System.Collections;
using System.Collections.Generic;
using UltimateXR.Core.Components.Composite;
using UltimateXR.Manipulation;
using UnityEngine;

public class WaterGun : UxrGrabbableObjectComponent<WaterGun>
{
    [SerializeField] ParticleSystem waterShoot;

    void Update()
    {
        if (UxrGrabManager.Instance.IsBeingGrabbed(GrabbableObject))
        {
            waterShoot.Play();
        }
        else
        {
            waterShoot.Stop();
        }
    }
}
