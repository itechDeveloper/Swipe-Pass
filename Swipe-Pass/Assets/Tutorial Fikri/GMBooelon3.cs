using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMBooelon3 : MonoBehaviour
{
    public bool TyuvarlakKPatladi = false;
    public TYuvarlakKirmizi tyk;
    public GameObject kaydirtext3;
    public GameObject sonmetin;

    
    public GameObject tutucu2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TyuvarlakKPatladi == true)
        {
            kaydirtext3.SetActive(false);
            tutucu2.SetActive(false);
            sonmetin.SetActive(true);
      
            
        }


    }
}
