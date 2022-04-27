using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutuScript : MonoBehaviour
{
    public GameObject GameOverContainer;

    void dead()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "killer")
        {

            HealthSystem.health -= 1;
           
                dead();
            
            
        }
    }

}