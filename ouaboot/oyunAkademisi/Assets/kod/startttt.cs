using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startttt : MonoBehaviour
{
    lwKilit lew;
    public GameObject lwkilll,aaaaa1;
    void Start()
    {
        lew = lwkilll.GetComponent<lwKilit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lew.b1 == 0)
        {
            aaaaa1.SetActive(true);
        }
        if (lew.b1 == 1)
        {
            aaaaa1.SetActive(false);
            
        }
    }

    public void bbbbbbbbbbbb ()
    {
        lew.b1 = 1;
    }
}
