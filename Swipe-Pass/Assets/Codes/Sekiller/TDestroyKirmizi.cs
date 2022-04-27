using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDestroyKirmizi : MonoBehaviour
{

    public GameObject TyuvarlakKirmizi;
    public TYuvarlakKirmizi TyuvarlakKirmiziScript;

    private void OnMouseDown()
    {
        TyuvarlakKirmizi = GameObject.FindGameObjectWithTag("TYuvarlakK");
        TyuvarlakKirmiziScript.getHit();
        TyuvarlakKirmiziScript.destroyYuvarlakKirmizi();
    }
}