using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMBooelon : MonoBehaviour
{

    public bool TyuvarlakMPatladi = false;
    public TYuvarlakMavi tym;
    public GameObject kaydirtext;
    public GameObject ikikeretikla;
    public GameObject tutucu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TyuvarlakMPatladi == true)
        {
            kaydirtext.SetActive(false);
            tutucu.SetActive(false);

        }

        
    }
}
