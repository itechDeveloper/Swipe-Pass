using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KutuKirmizi : MonoBehaviour
{
    // Start is called before the first frame update
    public int renk = 2;
    public int hit = 2;
    public bool barrier;
    public PageSwiper pageSwiper;
    public AudioSource karepatlama;

    public ParticleSystem deathAnimation;

    public void getHit()
    {
        if (pageSwiper.bg == renk || pageSwiper.rainbowActive)
        {
            hit -= 1;
        }

    }

    public void destroyKutuKirmizi()
    {
        if (hit == 0)
        {
            Instantiate(deathAnimation, transform.position, Quaternion.identity);

            ScoreScript.scoreValue += 20;
            karepatlama.Play();
            Destroy(gameObject);
        }
    }
}
