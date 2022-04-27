using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool iced;
    public bool icedDiactive;
    public bool icedActive;
    public float slowdownStartTime;
    public float slowdownCurrentTime;

    public float slowdownFactor = 0.05f;
    public float slowdownLenght = 2f;
    void Update()
    {
        if (iced) 
        {
            if (!icedActive) 
            {
                slowdownCurrentTime = slowdownStartTime;
                icedActive = true;
            }

            DoSlowMotion();
            slowdownCurrentTime -= Time.deltaTime;

            if (slowdownCurrentTime <= 0)
            {
                iced = false;
                icedActive = false;
                Time.timeScale = Time.timeScale * 20;
                //SmoothTimeScale();
            }
        }
    }
    public void DoSlowMotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
