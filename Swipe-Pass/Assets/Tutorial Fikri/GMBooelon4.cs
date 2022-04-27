using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMBooelon4 : MonoBehaviour
{

    public bool TyuvarlakMKPatladi = false;
    public TKareMavi tkm;
    public GameObject kaydirtext3;
    public GameObject sonmetin;

    public float saniye = 3f;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TyuvarlakMKPatladi == true)
        {
            kaydirtext3.SetActive(false);
           
            sonmetin.SetActive(true);

            saniye -= Time.deltaTime;
            if (saniye <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }


    }
}
