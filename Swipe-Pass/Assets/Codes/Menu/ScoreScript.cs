using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue;
    public Text score;

    public int HighScore;
    public Text highScoreText;


    // Start is called before the first frame update
    void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        if (HighScore < scoreValue)
        {
            HighScore = scoreValue;
        }

        highScoreText.text = "HIGH SCORE : " + HighScore.ToString();
        score.text = "SCORE : " + scoreValue.ToString();

        PlayerPrefs.SetInt("HighScore", HighScore);
    }

    void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("Score");
    }
}

/* 
 public int t;

*TUTTORIAL OYNANDI t++;*
PlayerPrefs.SetInt("Tuttorial", t);


*OYUN YENIDEN BASLADI*
t = PlayerPrefs.GetInt("Tuttorial");

 */
