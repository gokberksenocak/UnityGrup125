using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform ply;
    public float smt = 1;
    public Vector3 offset;


    private void FixedUpdate()
    {
        Vector3 des = ply.position + offset;
        Vector3 smtpositin = Vector3.Lerp(transform.position, des, smt);
        transform.position = smtpositin;

        transform.LookAt(ply);
    }

}
