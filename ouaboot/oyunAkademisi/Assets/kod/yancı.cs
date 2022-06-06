using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yancı : MonoBehaviour
{
    public GameObject ol, ol2;
    public int olll;
    void Start()
    {
        ol.SetActive(false);
        ol2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "dusman")
        {
            ol2.SetActive(true);
            Invoke("olum", 0.5f);
        }
    }
    public void ollll()
    {
        if (olll == 0)
        {
            SceneManager.LoadScene("sahne5");
        }
    
    }
        void olum()
    {
        ol.SetActive(true);

        Time.timeScale = 0;
    }


}
