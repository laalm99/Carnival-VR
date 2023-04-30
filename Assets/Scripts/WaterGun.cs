using System.Collections;
using System.Collections.Generic;
using UltimateXR.Core.Components.Composite;
using UltimateXR.Manipulation;
using UnityEngine;

public class WaterGun : UxrGrabbableObjectComponent<WaterGun>
{
    ParticleSystem waterShoot;

    private void Start()
    {
        waterShoot = this.GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (this.IsBeingGrabbed)
        {
            waterShoot.Play();
        }
    }
}
