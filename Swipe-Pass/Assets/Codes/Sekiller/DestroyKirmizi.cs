using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKirmizi : MonoBehaviour
{
    public GameObject yuvarlakKirmizi;
    public YuvarlakKirmizi yuvarlakKirmiziScript;

    private void OnMouseDown()
    {
        if (HealthSystem.health > 0)
        {
            yuvarlakKirmizi = GameObject.FindGameObjectWithTag("YuvarlakK");
            yuvarlakKirmiziScript.getHit();
            yuvarlakKirmiziScript.destroyYuvarlakKirmizi();
        }   
    }
}
