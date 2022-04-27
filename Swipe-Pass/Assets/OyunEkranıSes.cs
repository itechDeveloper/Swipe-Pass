using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunEkranıSes : MonoBehaviour
{
    public seskontrol seskss;
    public sesacma sesac;
    public seskisma seskis;

    public AudioSource oyunsound;

    private void Update()
    {
        seskss.ses = PlayerPrefs.GetInt("Ses");
        if (sesac.seskontrol.ses == 1)
        {

            AudioListener.volume = 0.5f;
        }

        else if (seskis.seskontrol.ses == 0)
        {

            AudioListener.volume = 0f;
        }
    }
}
