using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void click()
    {
        SceneManager.LoadScene("OyunEkranı");
        ScoreScript.scoreValue = 0;
    }
}
