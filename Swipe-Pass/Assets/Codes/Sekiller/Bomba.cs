using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public GameObject bomba;
    public BombaScript bombascript;


    private void OnMouseDown()
    {
        if (HealthSystem.health > 0)
        {
            bomba = GameObject.FindGameObjectWithTag("Bomba");
            bombascript.getHit();
            bombascript.destroyBomba();
        }
    }
}
