using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
    public int hit = 1;
    public bool barrier;
    public PageSwiper pageSwiper;
    public audiocontrol seskontrol;
    public AudioSource rainbowsesi;
    public ParticleSystem deathAnimation;


    public void getHit()
    {
        if (!pageSwiper.rainbowActive)
        {
            hit -= 1;
        }
    }
    public void destroyRainbow()
    {
        if (hit == 0)
        {
            Instantiate(deathAnimation, transform.position, Quaternion.identity);
            rainbowsesi.Play();
            seskontrol.rainbowtiklandi = true;
            pageSwiper.rainbow = true;
            Destroy(gameObject);
        }
    }
}
