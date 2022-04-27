using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class boxscript : MonoBehaviour
{
    public AudioSource destroysesi;
    public GameObject GameOverContainer;

    internal static bool kirmiziElectric;

    public ParticleSystem electricAnimation;

    void dead()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "killer")
        {
            HealthSystem.health -= 1;
            destroysesi.Play();
            dead();
            kirmiziElectric = true;
            Instantiate(electricAnimation, transform.position, Quaternion.identity);
            kirmiziElectric = false;
        }
    }
}
