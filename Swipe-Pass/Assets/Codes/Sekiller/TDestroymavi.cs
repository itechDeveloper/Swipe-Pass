using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDestroymavi : MonoBehaviour
{
    public GameObject TyuvarlakMavi;
    public TYuvarlakMavi TyuvarlakMaviScript;

    private void OnMouseDown()
    {
        TyuvarlakMavi = GameObject.FindGameObjectWithTag("TYuvarlakM");
        TyuvarlakMaviScript.getHit();
        TyuvarlakMaviScript.destroyYuvarlakMavi();
    }
}