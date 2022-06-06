using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lw2 : MonoBehaviour
{
    lwKilit lew;
    public GameObject lwkilll,l1a,l1b,l2a,l2b,l3a,l3b,l4a,l4b, l5a, l5b, l6a, l6b, l7a, l7b, l8a, l8b, l9a, l9b, l20a, l20b;
    void Start()
    {
        lew = lwkilll.GetComponent<lwKilit>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (lew.a2 == 0)
        {
            l2a.SetActive(true);
            l2b.SetActive(false);
        }
        if (lew.a2 == 1)
        {
            l2a.SetActive(false);
            l2b.SetActive(true);
        }

        if (lew.a3 == 0)
        {
            l3a.SetActive(true);
            l3b.SetActive(false);
        }
        if (lew.a3 == 1)
        {
            l3a.SetActive(false);
            l3b.SetActive(true);
        }

        if (lew.a4 == 0)
        {
            l4a.SetActive(true);
            l4b.SetActive(false);
        }

        if (lew.a4 == 1)
        {
            l4a.SetActive(false);
            l4b.SetActive(true);
        }

        if (lew.a5 == 0)
        {
            l5a.SetActive(true);
            l5b.SetActive(false);
        }

        if (lew.a5 == 1)
        {
            l5a.SetActive(false);
            l5b.SetActive(true);
        }

        if (lew.a6 == 0)
        {
            l6a.SetActive(true);
            l6b.SetActive(false);
        }

        if (lew.a6 == 1)
        {
            l6a.SetActive(false);
            l6b.SetActive(true);
        }

        if (lew.a7 == 0)
        {
            l7a.SetActive(true);
            l7b.SetActive(false);
        }

        if (lew.a7 == 1)
        {
            l7a.SetActive(false);
            l7b.SetActive(true);
        }

        if (lew.a8 == 0)
        {
            l8a.SetActive(true);
            l8b.SetActive(false);
        }

        if (lew.a8 == 1)
        {
            l8a.SetActive(false);
            l8b.SetActive(true);
        }

        if (lew.a9 == 0)
        {
            l9a.SetActive(true);
            l9b.SetActive(false);
        }

        if (lew.a9 == 1)
        {
            l9a.SetActive(false);
            l9b.SetActive(true);
        }

        if (lew.a10 == 0)
        {
            l20a.SetActive(true);
            l20b.SetActive(false);
        }

        if (lew.a10 == 1)
        {
            l20a.SetActive(false);
            l20b.SetActive(true);
        }
    }
    public void s1()
    {
        SceneManager.LoadScene("sahne1");
    }
    public void s2 ()
    {
        SceneManager.LoadScene("sahne2");
    }
    public void s3()
    {
        SceneManager.LoadScene("sahne3");
    }
    public void s4()
    {
        SceneManager.LoadScene("sahne4");
    }
    public void s5()
    {
        SceneManager.LoadScene("sahne5");
    }
    public void s6()
    {
        SceneManager.LoadScene("sahne6");
    }
    public void s7()
    {
        SceneManager.LoadScene("sahne7");
    }
    public void s8()
    {
        SceneManager.LoadScene("sahne8");
    }
    public void s9()
    {
        SceneManager.LoadScene("sahne9");
    }
    public void s10()
    {
        SceneManager.LoadScene("sahne10");
    }
}
