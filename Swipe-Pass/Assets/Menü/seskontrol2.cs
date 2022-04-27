using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seskontrol2 : MonoBehaviour
{
    public seskontrol ses;
    public int sesiki;

    // Start is called before the first frame update
    void Start()
    {
        if(ses.ses == 0)
        {
            sesiki = 0;
        }
        else if(ses.ses == 1)
        {
            sesiki = 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
