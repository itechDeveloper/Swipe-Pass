using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMBooelon2 : MonoBehaviour
{
    public bool TyuvarlakYPatladi = false;
    public TYuvarlakYesil tyy;
    public GameObject kaydirtext2;
   
    public GameObject tutucu;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TyuvarlakYPatladi == true)
        {
            kaydirtext2.SetActive(false);
            tutucu.SetActive(false);

        }


    }
}
