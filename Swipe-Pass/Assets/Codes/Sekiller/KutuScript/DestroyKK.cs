using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKK : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kirmizikutu;
    public KutuKirmizi KutuKirmiziScript;

    private void OnMouseDown()
    {
        if (HealthSystem.health > 0)
        {
            kirmizikutu = GameObject.FindGameObjectWithTag("KutuK");
            KutuKirmiziScript.getHit();
            KutuKirmiziScript.destroyKutuKirmizi();
        }
    }
}
