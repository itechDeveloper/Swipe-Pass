using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialFreezer : MonoBehaviour
{
    public GameObject mavitop;
    public GameObject kaydirma;
    public Rigidbody2D rb;
    

        void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Freeze")
        {

            kaydirma.SetActive(true);

            rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        }
     
    }



}



