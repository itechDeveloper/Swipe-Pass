using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDestroyYesil : MonoBehaviour
{

    public GameObject TyuvarlakYesil;
    public TYuvarlakYesil TyuvarlakYesilScript;

    private void OnMouseDown()
    {
        TyuvarlakYesil = GameObject.FindGameObjectWithTag("TYuvarlakY");
        TyuvarlakYesilScript.getHit();
        TyuvarlakYesilScript.destroyYuvarlakYesil();
    }
}