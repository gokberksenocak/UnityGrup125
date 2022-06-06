using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lwKilit : MonoBehaviour
{
    public int a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,b1;

    //  temel amac burdaki sayýlarý kaydetme get ile en sonki sayýyý çaðýrýp
    // set lede o ankini kaydediyoz sonra "startttt" scriptine gidersen anlarsýn burdaki kayýt olan deðeri caðýrýp
    //  b = 1se þu 0 ise bu mantýðý
    void Start()
    {
        b1 = PlayerPrefs.GetInt("b11");
        a1 = PlayerPrefs.GetInt("a11");
        a2 = PlayerPrefs.GetInt("a12");
        a3 = PlayerPrefs.GetInt("a13");
        a4 = PlayerPrefs.GetInt("a14");
        a5 = PlayerPrefs.GetInt("a15");
        a6 = PlayerPrefs.GetInt("a16");
        a7 = PlayerPrefs.GetInt("a17");
        a8 = PlayerPrefs.GetInt("a18");
        a9 = PlayerPrefs.GetInt("a19");
        a10 = PlayerPrefs.GetInt("a20");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("b11", b1);
        PlayerPrefs.SetInt("a11", a1);
        PlayerPrefs.SetInt("a12", a2);
        PlayerPrefs.SetInt("a13", a3);
        PlayerPrefs.SetInt("a14", a4);
        PlayerPrefs.SetInt("a15", a5);
        PlayerPrefs.SetInt("a16", a6);
        PlayerPrefs.SetInt("a17", a7);
        PlayerPrefs.SetInt("a18", a8);
        PlayerPrefs.SetInt("a19", a9);
        PlayerPrefs.SetInt("a20", a10);
    }
}
