using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiocontrol : MonoBehaviour
{

    public float starttime;
    public float currentime;
    public AudioSource oyunsesi;
    public float A;

    public bool rainbowtiklandi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (rainbowtiklandi)
        {
            currentime = starttime;
            rainbowtiklandi = false;
        }

        oyunsesi.volume = A;

        if (currentime > 0)
        {
            currentime -= Time.deltaTime;



            oyunsesi.volume = 0;
        }

        else if(currentime <= 0)
        {
            rainbowtiklandi = false;
            oyunsesi.volume = A;
        }
    
    }
}
