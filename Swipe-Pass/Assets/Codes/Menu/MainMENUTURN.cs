using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMENUTURN : MonoBehaviour
{
   
    public void click()
    {
        SceneManager.LoadScene("Menu");
        ScoreScript.scoreValue = 0;
    }

}
