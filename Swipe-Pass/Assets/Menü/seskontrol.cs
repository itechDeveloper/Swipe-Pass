using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seskontrol : MonoBehaviour
{
    internal int ses;

    public sesacma sesac;
    public seskisma seskis;

    private int active;

    private int sesBaslangic;

    private void Start()
    {
        sesBaslangic = PlayerPrefs.GetInt("SesBaslangic");

        if (sesBaslangic == 0)
        {
            PlayerPrefs.SetInt("Ses", 1);
            sesBaslangic = 1;
            PlayerPrefs.SetInt("SesBaslangic", sesBaslangic);
        }    
    }

    private void Update()
    {
        active = PlayerPrefs.GetInt("Ses");

        if(active == 1)
        {

            sesac.gameObject.SetActive(false);
            seskis.gameObject.SetActive(true);
        }

        else if (active == 0)
        {
            sesac.gameObject.SetActive(true);
            seskis.gameObject.SetActive(false);
        }
    }

}
