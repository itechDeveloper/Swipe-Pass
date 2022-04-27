using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TYuvarlakMavi : MonoBehaviour
{
   
    public int renk = 3;
    public int hit = 1;
    public bool barrier;
    public PageSwiper pageSwiper;
    public GMBooelon gmb;
    public ParticleSystem deathAnimation;
    public AudioSource patlamases;


    public void getHit()
    {
        if (pageSwiper.bg == renk || pageSwiper.rainbowActive)
        {
            hit -= 1;
        }

    }

    public void destroyYuvarlakMavi()
    {
        if (hit == 0)
        {
            Instantiate(deathAnimation, transform.position, Quaternion.identity);
               patlamases.Play();
            gmb.TyuvarlakMPatladi = true;
            Destroy(gameObject);
        }
    }
}
