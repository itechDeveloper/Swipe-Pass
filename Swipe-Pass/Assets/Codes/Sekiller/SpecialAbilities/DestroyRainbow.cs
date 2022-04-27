using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRainbow : MonoBehaviour
{
    public GameObject rainbowBall;
    public Rainbow rainbow;

    private void OnMouseDown()
    {
        if (HealthSystem.health > 0)
        {
            rainbowBall = GameObject.FindGameObjectWithTag("rainbow");
            rainbow.getHit();
            rainbow.destroyRainbow();
        }
    }
}
