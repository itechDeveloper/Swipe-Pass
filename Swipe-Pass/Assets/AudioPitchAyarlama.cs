using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPitchAyarlama : MonoBehaviour
{
    public AudioSource gamerunsound;
    public seskontrol sesks;


    // Start is called before the first frame update
    void Start()
    {

        if(sesks.ses == 0)
        {
            gamerunsound.volume = 0f;
        }

        else if(sesks.ses == 1)
        {
            gamerunsound.volume = 0.5f;
        }
        gamerunsound.pitch = 0.95f;

    }

    // Update is called once per frame
    void Update()
    {

        if (ScoreScript.scoreValue > 150 && ScoreScript.scoreValue <300)
        {
            gamerunsound.pitch = 0.96f;
        }

        else if (ScoreScript.scoreValue > 300 && ScoreScript.scoreValue < 450)
        {
            
            gamerunsound.pitch = 0.98f;
        }

        else if (ScoreScript.scoreValue > 450 && ScoreScript.scoreValue < 600)
        {
            gamerunsound.pitch = 0.99f;
        }

        else if (ScoreScript.scoreValue > 600 && ScoreScript.scoreValue < 750)
        {
            gamerunsound.pitch = 1.00f;
        }

        else if (ScoreScript.scoreValue > 750 && ScoreScript.scoreValue < 900)
        {
            gamerunsound.pitch = 1.01f;
        }

        else if (ScoreScript.scoreValue > 900 && ScoreScript.scoreValue < 1050)
        {
            gamerunsound.pitch = 1.02f;
        }


        else if (ScoreScript.scoreValue > 1050 && ScoreScript.scoreValue < 1200)
        {
            gamerunsound.pitch = 1.03f;
        }


        else if (ScoreScript.scoreValue > 1200 && ScoreScript.scoreValue < 1350)
        {
            gamerunsound.pitch = 1.04f;
        }


        else if (ScoreScript.scoreValue > 1350 && ScoreScript.scoreValue < 1500)
        {
            gamerunsound.pitch = 1.05f;
        }

        else if (ScoreScript.scoreValue > 1500 && ScoreScript.scoreValue < 1650)
        {
            gamerunsound.pitch = 1.07f;
        }

        else if (ScoreScript.scoreValue > 1650 && ScoreScript.scoreValue < 1800)
        {
            gamerunsound.pitch = 1.08f;
        }

        else if (ScoreScript.scoreValue > 1800 && ScoreScript.scoreValue < 1950)
        {
            gamerunsound.pitch = 1.09f;
        }

        else if (ScoreScript.scoreValue > 1950 && ScoreScript.scoreValue < 2100)
        {
            gamerunsound.pitch = 1.10f;
        }

        else if (ScoreScript.scoreValue > 2100 && ScoreScript.scoreValue < 2250)
        {
            gamerunsound.pitch = 1.11f;
        }

        else if (ScoreScript.scoreValue > 2250 && ScoreScript.scoreValue < 2400)
        {
            gamerunsound.pitch = 1.12f;
        }

        else if (ScoreScript.scoreValue > 2400 && ScoreScript.scoreValue < 2550)
        {
            gamerunsound.pitch = 1.13f;
        }

        else if (ScoreScript.scoreValue > 2550 && ScoreScript.scoreValue < 2700)
        {
            gamerunsound.pitch = 1.14f;
        }

        else if (ScoreScript.scoreValue > 2700 && ScoreScript.scoreValue < 2850)
        {
            gamerunsound.pitch = 1.15f;
        }

        else if (ScoreScript.scoreValue > 2850 && ScoreScript.scoreValue < 3000)
        {
            gamerunsound.pitch = 1.16f;
        }

        else if (ScoreScript.scoreValue > 3000 && ScoreScript.scoreValue < 3150)
        {
            gamerunsound.pitch = 1.17f;
        }

        else if (ScoreScript.scoreValue > 3150 && ScoreScript.scoreValue < 3300)
        {
            gamerunsound.pitch = 1.18f;
        }

        else if (ScoreScript.scoreValue > 3300 && ScoreScript.scoreValue < 3450)
        {
            gamerunsound.pitch = 1.19f;
        }

        else if (ScoreScript.scoreValue > 3450 && ScoreScript.scoreValue < 3600)
        {
            gamerunsound.pitch = 1.20f;
        }

        else if (ScoreScript.scoreValue > 3600 && ScoreScript.scoreValue < 11152350)
        {
            gamerunsound.pitch = 1.21f;
        }

    }

    
}
