using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyYesi : MonoBehaviour
{
    public GameObject yuvarlakYesil;
    public YuvarlakYesil yuvarlakYesilScript;

    private void OnMouseDown()
    {
        if (HealthSystem.health > 0)
        {
            yuvarlakYesil = GameObject.FindGameObjectWithTag("YuvarlakY");
            yuvarlakYesilScript.getHit();
            yuvarlakYesilScript.destroyYuvarlakYesil();
        }
    }
}
