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
            cans[i].ResetPosition += ResetCans;
        }
    }

    private void Update()
    {
        timer -= Time.deltaTime;
    }

    void ResetCans()
    {
        timer = 3;
        if(timer <= 0)
        {
            for(int i=0; i<cans.Length; i++)
            {
                cans[i].transform.position = cans[i].StartPos;
                //cans[i].transform.rotation = cans[i].StartRotation;
            }
        }
    }

  
}
