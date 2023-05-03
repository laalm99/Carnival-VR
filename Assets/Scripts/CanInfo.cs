using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanInfo : MonoBehaviour
{
    private Vector3 startPos;
    public Vector3 StartPos => startPos;
    private Vector3 startRotation;
    public Vector3 StartRotation => startRotation;

    public event Action ResetPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startRotation = transform.eulerAngles;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ball"))
        {
            ResetPosition?.Invoke();

        }
    }


}
