using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class basla : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public void baslat()
    {
        panel.SetActive(false);
    }
}