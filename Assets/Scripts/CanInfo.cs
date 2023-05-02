using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanInfo : MonoBehaviour
{
    private Transform startPos;
    public Transform StartPos => startPos;

    public event Action ResetPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPos.position = transform.position;
        startPos.rotation = transform.rotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        ResetPosition?.Invoke();
    }


}
