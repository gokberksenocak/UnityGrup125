using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]
public class joy : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joyyy;
    [SerializeField] private float _move;
    public float powera;
    public GameObject ol,ol2;

    public bool ab123;

    public Transform droneee, droneee1;
    Vector3 starPositosn;

    public void Start()
    {
        ol.SetActive(false);
        ol2.SetActive(false);
        Time.timeScale = 1;
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joyyy.Horizontal * _move, _rigidbody.velocity.y, _joyyy.Vertical * _move);
   
        if (_joyyy.Horizontal != 0 || _joyyy.Vertical !=0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }

        if (ab123)
        {
            Quaternion rotation = Quaternion.LookRotation(droneee.transform.position - transform.position);

            starPositosn = droneee.localPosition;
            droneee1.localPosition = starPositosn + Random.insideUnitSphere * powera;

        }

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "dusman")
        {
            ab123 = true;
            ol2.SetActive(true);
            Invoke("olum", 0.5f);
        }
        if (col.gameObject.tag == "sah1")
        {
            SceneManager.LoadScene("sahne2");
        }
        if (col.gameObject.tag == "sah2")
        {
            SceneManager.LoadScene("sahne3");
        }
        if (col.gameObject.tag == "sah3")
        {
            SceneManager.LoadScene("sahne4");
        }
        if (col.gameObject.tag == "sah4")
        {
            SceneManager.LoadScene("sahne5");
        }
    }

    public void ollll()
    {
        SceneManager.LoadScene("sahne1");
    }
    void olum()
    {
        ol.SetActive(true);

        Time.timeScale = 0;
    }

}
