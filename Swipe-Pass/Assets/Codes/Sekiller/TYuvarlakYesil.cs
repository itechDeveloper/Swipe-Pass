using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TYuvarlakYesil : MonoBehaviour
{


    public int renk = 1;
    public int hit = 1;
    public bool barrier;
    public PageSwiper pageSwiper;
    public GMBooelon2 gmb;
    public AudioSource patlamases;
    public ParticleSystem deathAnimation;


    public void getHit()
    {
        if (pageSwiper.bg == renk || pageSwiper.rainbowActive)
        {
            hit -= 1;
        }

    }

    public void destroyYuvarlakYesil()
    {
        if (hit == 0)
        {

            Instantiate(deathAnimation, transform.position, Quaternion.identity);
            patlamases.Play();
            gmb.TyuvarlakYPatladi = true;
            Destroy(gameObject);
        }
    }
}
