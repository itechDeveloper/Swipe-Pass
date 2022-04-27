using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialFreezer2 : MonoBehaviour
{

    public GameObject yesiltop;
    public GameObject kaydirma2;
    public Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Freeze")
        {

            kaydirma2.SetActive(true);

            rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        }

    }



}


