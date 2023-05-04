using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHouse : MonoBehaviour
{
    [SerializeField] private GameObject house;
    private bool toggle = false;

    public void Add()
    {
        toggle = !toggle;
        house.SetActive(toggle);
    }
}
