using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuvarlakMavi : MonoBehaviour
{
    public int renk = 3;
    public int hit = 1;
    public PageSwiper pageSwiper;
    public AudioSource patlamases;

    public ParticleSystem  deathAnimation;
  
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
            ScoreScript.scoreValue += 10;   
            Destroy(gameObject);
        }
    }
}
