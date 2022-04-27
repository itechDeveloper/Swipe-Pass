using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialFreezer4 : MonoBehaviour
{
    public GameObject mavikutu;
    public GameObject kaydirma4;
    public Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Freeze")
        {

            kaydirma4.SetActive(true);

            rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        }

    }



}
