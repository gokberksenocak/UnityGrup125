using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]
public class joy : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joyyy;
    public float _move, _move2;
    public float kos,powera, powera2;
    public GameObject lwkilll,ol,ol2;
    public GameObject _panel2;
    public Scene _scene;
    public bool ab123;
    public TMPro.TextMeshProUGUI kosbbbb;
    public int kosb,olll;

    public Transform droneee, droneee1;
    Vector3 starPositosn;

    lwKilit lew;

    public void Start()
    {
        lew = lwkilll.GetComponent<lwKilit>();
        _move = 3;
        _move2 = 10;
        ol.SetActive(false);
        ol2.SetActive(false);
        Time.timeScale = 1;
        kos = 0;
        kosb = 1000;
        kosbbbb.GetComponent<TextMeshProUGUI>();
        _scene = SceneManager.GetActiveScene();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        if (kos < 1)
        {
            _rigidbody.velocity = new Vector3(_joyyy.Horizontal * _move, _rigidbody.velocity.y, _joyyy.Vertical * _move);
        }
        if (kos >= 1)
        {
            _rigidbody.velocity = new Vector3(_joyyy.Horizontal * _move, _rigidbody.velocity.y, _joyyy.Vertical * _move2);
        }


        if (_joyyy.Horizontal != 0 || _joyyy.Vertical !=0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
        kosbbbb.text = kosb.ToString();

        if ( kos >= 1 && kos < 2)
        {
            kosb -= 1;
            if (kosb < 0 )
            {
                kosb = 0;
                kos = 0;
            }
        }
		if ( kos > 1)
        {
           kos = 0;
        }
        if (ab123)
        {
            Quaternion rotation = Quaternion.LookRotation(droneee.transform.position - transform.position);

            starPositosn = droneee.localPosition;
           
                droneee1.localPosition = starPositosn + Random.insideUnitSphere * powera;
            
          
        }
		

    }

    public void kosaaa ()
    {
		kos ++;
       

    }
    public void kosaaaddddddddd()
    {
        kos = 0;

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "don")
        {
            kosb += 50;
        }

        if (col.gameObject.tag == "dusman")
        {
            ab123 = true;
            ol2.SetActive(true);
            Invoke("olum", 0.5f);
        }
        if (col.gameObject.tag == "sah1")
        {
            lew.a2 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "sah2")
        {
            lew.a3 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "sah3")
        {
            lew.a4 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "sah4")
        {
            lew.a5 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "sah5")
        {
            lew.a6 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "sah6")
        {
            lew.a7 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "sah7")
        {
            lew.a8 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "sah8")
        {
            lew.a9 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "sah9")
        {
            lew.a10 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag == "sah10")
        {
            lew.a10 = 1;
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
    }
    void olum()
    {
        ol.SetActive(true);

        Time.timeScale = 0;
    }
    public void Nextlevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(_scene.buildIndex);
    }
    public void OpeningScene()
    {
        SceneManager.LoadScene(0);
    }
}