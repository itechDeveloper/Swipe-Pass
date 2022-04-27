using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seskisma : MonoBehaviour
{
    public seskontrol seskontrol;  

    public void clickseskapat()
    {
        seskontrol.ses = 0;
        PlayerPrefs.SetInt("Ses", seskontrol.ses);
    }  
}


