using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMK : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mavikutu;
    public KutuMavi KutuMaviScript;

    private void OnMouseDown()
    {
        if (HealthSystem.health > 0)
        {
            mavikutu = GameObject.FindGameObjectWithTag("KutuK");
            KutuMaviScript.getHit();
            KutuMaviScript.destroyKutuMavi();
        }
    }
}