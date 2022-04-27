using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyYK : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject yesilkutu;
    public KutuYesil KutuYesilScript;

    private void OnMouseDown()
    {
        if (HealthSystem.health > 0)
        {
            yesilkutu = GameObject.FindGameObjectWithTag("KutuK");
            KutuYesilScript.getHit();
            KutuYesilScript.destroyKutuYesil();
        }
    }
}