using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    public int hit = 1;
    public bool barrier;
    public AudioSource kalpsesi;

    public ParticleSystem deathAnimation;

    public void getHit()
    {
        hit -= 1;

    }

    public void destroyHeart()
    {
        if (hit == 0)
        {
            Instantiate(deathAnimation, transform.position, Quaternion.identity);

            HealthSystem.health += 1;
            ScoreScript.scoreValue += 10;
            kalpsesi.Play();
            Destroy(gameObject);
        }
    }
}