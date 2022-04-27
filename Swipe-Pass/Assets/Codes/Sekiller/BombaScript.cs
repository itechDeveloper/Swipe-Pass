using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaScript : MonoBehaviour
{
    public int hit = 1;
    public Rigidbody2D rb;
    public Collider2D circleCollider;
    public CameraShaker cameraShaker;
    public AudioSource bombasesi;

    public ParticleSystem deathAnimation;

    public void getHit()
    {
            hit -= 1;
    }

    public void destroyBomba()
    {
        if (hit == 0)
        {
            cameraShaker.cameraShake = true;
            circleCollider.enabled = false;
            bombasesi.Play();
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
            PlayAnimation();
            gameObject.SetActive(false);
            Invoke("makeHealthZero", 1f);
            Invoke("destroy",1f);
        }
    }

    void makeHealthZero()
    {
        HealthSystem.health = 0;
    }

    void PlayAnimation()
    {
        Instantiate(deathAnimation, transform.position, Quaternion.identity);
    }

    void destroy()
    {  
        Destroy(gameObject);
    }

}
