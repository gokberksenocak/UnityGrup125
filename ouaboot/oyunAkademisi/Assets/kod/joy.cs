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

    // Update is called once per frame
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joyyy.Horizontal * _move, _rigidbody.velocity.y, _joyyy.Vertical * _move);
   
        if (_joyyy.Horizontal != 0 || _joyyy.Vertical !=0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
    
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "dusman")
        {
            SceneManager.LoadScene("sahne1");
        }
        if (col.gameObject.tag == "sah1")
        {
            SceneManager.LoadScene("sahne2");
        }
    }

}
