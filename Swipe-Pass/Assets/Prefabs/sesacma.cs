using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesacma : MonoBehaviour
{

    public seskontrol seskontrol;

    public void clicksesacma()
    {
        seskontrol.ses = 1;
        PlayerPrefs.SetInt("Ses", seskontrol.ses);
    }
}
