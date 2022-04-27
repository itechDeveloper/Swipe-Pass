using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TYuvarlakKirmizi : MonoBehaviour
{

    public int renk = 2;
    public int hit = 1;
    public bool barrier;
    public PageSwiper pageSwiper;
    public GMBooelon3 gmb;
    public AudioSource patlamases;
    public ParticleSystem deathAnimation;

    public void getHit()
    {
        if (pageSwiper.bg == renk || pageSwiper.rainbowActive)
        {
            hit -= 1;
        }

    }

    public void destroyYuvarlakKirmizi()
    {
        if (hit == 0)
        {
            Instantiate(deathAnimation, transform.position, Quaternion.identity);
            patlamases.Play();
            
            gmb.TyuvarlakKPatladi = true;
            Destroy(gameObject);
        }
    }
}
