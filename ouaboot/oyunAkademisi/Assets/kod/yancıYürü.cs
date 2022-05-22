using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yancıYürü : MonoBehaviour
{
    public GameObject[] way; // arada yürünicek mesafa listesi
    public int cur; // arada yürünicek mesafa objesi
    public float hiz,mesafe; 
    Vector3 poz2; // metre
    void Start()
    {
        hiz = Random.Range(0.5f, 3); // random hız değieri
        cur = 0;
    }

    // Update is called once per frame
    void Update()
    {


        poz2 = new Vector3(way[cur].transform.position.x, transform.position.y, way[cur].transform.position.z); //  alanları arada yürünicek mesafa objesi metresini belirliyoz xyz 




        if (mesafe == 1 )
        {
           
         //   GetComponent<Animation>().Play("idle");
        }
        if (mesafe == 3)
        {

          //  GetComponent<Animation>().Play("idlewolf22");
        }

        if (mesafe == 0)
        {
           
            if (Vector3.Distance(way[cur].transform.position, this.transform.position) < 0.5) // metre 0 ise bizim nesneyle gidiceğimiz nesnenin
            {
                cur++; 
                if (cur >= way.Length)
                {
                    cur = 0;
                }
            }
            Quaternion rotation = Quaternion.LookRotation(way[cur].transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 2);
            transform.LookAt(poz2);
            transform.Translate(0, 0, hiz*Time.deltaTime);
      //      GetComponent<Animation>().Play("walk");

        }
        if (mesafe == 2)
        {

            if (Vector3.Distance(way[cur].transform.position, this.transform.position) < 0.5)
            {
                cur++;
                if (cur >= way.Length)
                {
                    cur = 0;
                }
            }
            Quaternion rotation = Quaternion.LookRotation(way[cur].transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 2);
            transform.LookAt(poz2);
            transform.Translate(0, 0, hiz * Time.deltaTime);
           // GetComponent<Animation>().Play("idlewolf");

        }


    }
}

