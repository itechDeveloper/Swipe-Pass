using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuvarlakKirmizi : MonoBehaviour
{
    public int renk = 2;
    public int hit = 1;
    public PageSwiper pageSwiper;
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

            ScoreScript.scoreValue += 10;
            patlamases.Play();
            Destroy(gameObject);
        }
    }
}
