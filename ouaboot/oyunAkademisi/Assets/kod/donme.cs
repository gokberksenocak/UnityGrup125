using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donme : MonoBehaviour
{
    public Transform aaa;
    public GameObject aaaaaaaaaaa;
    public float say;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aaa.Rotate(Vector3.up, Time.deltaTime * 30);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "karakterr")
        {
            aaaaaaaaaaa.SetActive(false);
        }
    }
 }
