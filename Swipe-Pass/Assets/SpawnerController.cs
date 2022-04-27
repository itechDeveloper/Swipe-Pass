using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    public GameObject yuzelliskor, dortyuzskor, yediyuzskor, binyuzskor, binbeşyüzskor,
        bindokuzyüzskor, ikibindörtyüzskor, ucbinskor, 
        dortbinskor,specialspawner,bombheartspawner,specialspawner1;
    public seskontrol sess;
    
    

    // Start is called before the first frame update
    void Start()
    {
        yuzelliskor.gameObject.SetActive(true);
        dortyuzskor.gameObject.SetActive(false);
        yediyuzskor.gameObject.SetActive(false);
        binyuzskor.gameObject.SetActive(false);
        binbeşyüzskor.gameObject.SetActive(false);
        bindokuzyüzskor.gameObject.SetActive(false);
        ikibindörtyüzskor.gameObject.SetActive(false);
        ucbinskor.gameObject.SetActive(false);
        dortbinskor.gameObject.SetActive(false);
        specialspawner.gameObject.SetActive(false);
        bombheartspawner.gameObject.SetActive(false);
        specialspawner1.gameObject.SetActive(false);
        Spawner.tekraretme = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreScript.scoreValue > 0 && ScoreScript.scoreValue <= 150)
        {
            yuzelliskor.gameObject.SetActive(true);
            dortyuzskor.gameObject.SetActive(false);
            yediyuzskor.gameObject.SetActive(false);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(false);
            bindokuzyüzskor.gameObject.SetActive(false);
            ikibindörtyüzskor.gameObject.SetActive(false);
            ucbinskor.gameObject.SetActive(false);
            dortbinskor.gameObject.SetActive(false);
            specialspawner.gameObject.SetActive(false);
            specialspawner1.gameObject.SetActive(false);
            bombheartspawner.gameObject.SetActive(false);
            Spawner.tekraretme = 1f;

        }

        else if (ScoreScript.scoreValue > 150 && ScoreScript.scoreValue <= 400)
        {
            yuzelliskor.gameObject.SetActive(false);
            dortyuzskor.gameObject.SetActive(true);
            yediyuzskor.gameObject.SetActive(false);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(false);
            bindokuzyüzskor.gameObject.SetActive(false);
            ikibindörtyüzskor.gameObject.SetActive(false);
            ucbinskor.gameObject.SetActive(false);
            dortbinskor.gameObject.SetActive(false);
            specialspawner1.gameObject.SetActive(true);
            specialspawner.gameObject.SetActive(false);
            bombheartspawner.gameObject.SetActive(false);
            Spawner.tekraretme = 5f;
            SpecialSpawner.specialtekraretme = 40f;
            BombHeartSpawner.bombhearttekraretme = 36f;

        }
        
        else if (ScoreScript.scoreValue > 400 && ScoreScript.scoreValue <= 700)
        {
            yuzelliskor.gameObject.SetActive(false);
            dortyuzskor.gameObject.SetActive(false);
            yediyuzskor.gameObject.SetActive(true);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(false);
            bindokuzyüzskor.gameObject.SetActive(false);
            ikibindörtyüzskor.gameObject.SetActive(false);
            ucbinskor.gameObject.SetActive(false);
            dortbinskor.gameObject.SetActive(false);
            specialspawner.gameObject.SetActive(true);
            specialspawner1.gameObject.SetActive(true);
            bombheartspawner.gameObject.SetActive(true);
            Spawner.tekraretme = 5f;

        }

        else if (ScoreScript.scoreValue > 700 && ScoreScript.scoreValue <= 1000)
        {
            yuzelliskor.gameObject.SetActive(false);
            dortyuzskor.gameObject.SetActive(false);
            yediyuzskor.gameObject.SetActive(false);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(true);
            bindokuzyüzskor.gameObject.SetActive(false);
            ikibindörtyüzskor.gameObject.SetActive(false);
            ucbinskor.gameObject.SetActive(false);
            dortbinskor.gameObject.SetActive(false);
            specialspawner.gameObject.SetActive(true);
            specialspawner1.gameObject.SetActive(true);
            bombheartspawner.gameObject.SetActive(true);
            Spawner.tekraretme = 5f;

        }

        else if (ScoreScript.scoreValue > 1000 && ScoreScript.scoreValue <= 1500)
        {
            yuzelliskor.gameObject.SetActive(false);
            dortyuzskor.gameObject.SetActive(false);
            yediyuzskor.gameObject.SetActive(false);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(true);
            bindokuzyüzskor.gameObject.SetActive(false);
            ikibindörtyüzskor.gameObject.SetActive(false);
            ucbinskor.gameObject.SetActive(false);
            dortbinskor.gameObject.SetActive(false);
            specialspawner.gameObject.SetActive(true);
            specialspawner1.gameObject.SetActive(true);
            bombheartspawner.gameObject.SetActive(true);
            Spawner.tekraretme = 5f;

        }

        else if (ScoreScript.scoreValue > 1500 && ScoreScript.scoreValue <= 1900)
        {
            yuzelliskor.gameObject.SetActive(false);
            dortyuzskor.gameObject.SetActive(false);
            yediyuzskor.gameObject.SetActive(false);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(false);
            bindokuzyüzskor.gameObject.SetActive(true);
            ikibindörtyüzskor.gameObject.SetActive(false);
            ucbinskor.gameObject.SetActive(false);
            dortbinskor.gameObject.SetActive(false);
            specialspawner.gameObject.SetActive(true);
            specialspawner1.gameObject.SetActive(true);
            bombheartspawner.gameObject.SetActive(true);
            Spawner.tekraretme = 5f;
        }

        else if (ScoreScript.scoreValue > 1900 && ScoreScript.scoreValue <= 2400)
        {
            yuzelliskor.gameObject.SetActive(false);
            dortyuzskor.gameObject.SetActive(false);
            yediyuzskor.gameObject.SetActive(false);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(false);
            bindokuzyüzskor.gameObject.SetActive(false);
            ikibindörtyüzskor.gameObject.SetActive(true);
            ucbinskor.gameObject.SetActive(false);
            dortbinskor.gameObject.SetActive(false);
            specialspawner.gameObject.SetActive(true);
            specialspawner1.gameObject.SetActive(true);
            bombheartspawner.gameObject.SetActive(true);
            Spawner.tekraretme = 5f;
        }

        else if (ScoreScript.scoreValue > 2400 && ScoreScript.scoreValue <= 3000)
        {
            yuzelliskor.gameObject.SetActive(false);
            dortyuzskor.gameObject.SetActive(false);
            yediyuzskor.gameObject.SetActive(false);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(false);
            bindokuzyüzskor.gameObject.SetActive(false);
            ikibindörtyüzskor.gameObject.SetActive(false);
            ucbinskor.gameObject.SetActive(true);
            dortbinskor.gameObject.SetActive(false);
            specialspawner.gameObject.SetActive(true);
            specialspawner1.gameObject.SetActive(true);
            bombheartspawner.gameObject.SetActive(true);
            Spawner.tekraretme = 5f;
        }

        else if (ScoreScript.scoreValue > 3000 && ScoreScript.scoreValue <= 4000)
        {
            yuzelliskor.gameObject.SetActive(false);
            dortyuzskor.gameObject.SetActive(false);
            yediyuzskor.gameObject.SetActive(false);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(false);
            bindokuzyüzskor.gameObject.SetActive(false);
            ikibindörtyüzskor.gameObject.SetActive(false);
            ucbinskor.gameObject.SetActive(false);
            dortbinskor.gameObject.SetActive(true);
            specialspawner.gameObject.SetActive(true);
            specialspawner1.gameObject.SetActive(true);
            bombheartspawner.gameObject.SetActive(true);
            Spawner.tekraretme = 5f;
        }

        else if (ScoreScript.scoreValue > 4000 && ScoreScript.scoreValue <= 1234000)
        {
            yuzelliskor.gameObject.SetActive(false);
            dortyuzskor.gameObject.SetActive(false);
            yediyuzskor.gameObject.SetActive(false);
            binyuzskor.gameObject.SetActive(false);
            binbeşyüzskor.gameObject.SetActive(false);
            bindokuzyüzskor.gameObject.SetActive(false);
            ikibindörtyüzskor.gameObject.SetActive(false);
            ucbinskor.gameObject.SetActive(false);
            dortbinskor.gameObject.SetActive(true);
            specialspawner.gameObject.SetActive(true);
            specialspawner1.gameObject.SetActive(true);
            bombheartspawner.gameObject.SetActive(true);
            Spawner.tekraretme = 5f;
        }


    }
}
