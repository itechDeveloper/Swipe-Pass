using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDestroyMaviKutu : MonoBehaviour
{
    public GameObject TKutuMavi;
    public TKareMavi TmaviMaviScript;

    private void OnMouseDown()
    {
        TKutuMavi = GameObject.FindGameObjectWithTag("TkutuM");
        TmaviMaviScript.getHit();
        TmaviMaviScript.destroyYuvarlakMavi();
    }
}