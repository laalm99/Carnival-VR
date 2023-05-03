using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanManager : MonoBehaviour
{

    [SerializeField] CanInfo[] cans = new CanInfo[6];
    private float timer = 0;



    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i<cans.Length; i++)
        {
            cans[i].ResetPosition += StarTimer;
        }
    }

    void Update()
    {
        timer -= Time.deltaTime;
        ResetCans();
    }

    void StarTimer()
    {
        timer = 3;

    }

    void ResetCans()
    {
        if(timer <= 0)
        {
            for(int i=0; i<cans.Length; i++)
            {
                cans[i].transform.position = cans[i].StartPos;
                cans[i].transform.eulerAngles = cans[i].StartRotation;
            }
        }
    }

  
}
