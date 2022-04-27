using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public tutorialkontrol tutorialk;
    public void PlayGame()
    {
        tutorialk.firsttime = PlayerPrefs.GetInt("Tutorial");


        if(tutorialk.firsttime == 0)
        {
            

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            tutorialk.firsttime += 1;

            PlayerPrefs.SetInt("Tutorial", tutorialk.firsttime);
           
        }   
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

}
