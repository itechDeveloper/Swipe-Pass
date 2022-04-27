using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMavi : MonoBehaviour
{
    public GameObject yuvarlakMavi;
    public YuvarlakMavi yuvarlakMaviScript;

    private void OnMouseDown()
    {
        if (HealthSystem.health > 0)
        {
            yuvarlakMavi = GameObject.FindGameObjectWithTag("YuvarlakM");
            yuvarlakMaviScript.getHit();
            yuvarlakMaviScript.destroyYuvarlakMavi();
        }
    }
}
