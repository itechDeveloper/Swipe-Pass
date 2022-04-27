using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialFreezer3 : MonoBehaviour
{

    public GameObject kirmizitop;
    public GameObject kaydirma3;
    public Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Freeze")
        {

            kaydirma3.SetActive(true);

            rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        }

    }



}
