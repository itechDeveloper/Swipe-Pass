using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public GameObject heart;
    public HeartScript heartscript;

    private void OnMouseDown()
    {
        if (HealthSystem.health > 0)
        {
            heart = GameObject.FindGameObjectWithTag("Kalp");
            heartscript.getHit();
            heartscript.destroyHeart();
        }
    }
}
