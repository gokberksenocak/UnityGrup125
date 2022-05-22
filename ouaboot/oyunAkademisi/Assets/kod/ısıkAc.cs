using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ısıkAc : MonoBehaviour
{
    public GameObject ısık;
    public int ıaa;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ıaa > 0)
        {
            ısık.SetActive(true);
        }
        if (ıaa < 0)
        {
            ısık.SetActive(false);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag== "duvar")
        {
            ıaa = -5;
        }
        else
        {
            ıaa = 5;
        }
    }
}
