using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldActivateScript : MonoBehaviour {

    public GameObject Shield = new GameObject();
    //public bool SetActive = false;
    void Start()
    {
        Shield.gameObject.SetActive(false);
    }
    void Update()
    {
    }
    // Use this for initialization
    // void OnTriggerEnter(Collider other)
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {

            Shield.gameObject.SetActive(true);
        }
    }
}
