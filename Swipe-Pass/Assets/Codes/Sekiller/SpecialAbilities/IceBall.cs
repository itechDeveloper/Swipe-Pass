using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBall : MonoBehaviour
{
    public int hit = 1;
    public bool barrier;
    public PageSwiper pageSwiper;
    public Timer timerScript;
    public AudioSource iceballses;

    public ParticleSystem deathAnimation;

    public void getHit()
    {
        hit -= 1;
    }

    public void destroyIceBall()
    {
        if (hit == 0)
        {
            Instantiate(deathAnimation, transform.position, Quaternion.identity);
            iceballses.Play();
            timerScript.iced = true;
            Destroy(gameObject);
        }
    }
}
