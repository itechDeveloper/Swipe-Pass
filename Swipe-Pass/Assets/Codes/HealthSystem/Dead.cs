using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    private void Update()
    {
        RestartGame();
    }

    void RestartGame()
    {
        if (HealthSystem.health == 0)
        {
            Spawner.spawnAllowed = false;

        }
        else if (HealthSystem.health > 0)
        {
            Spawner.spawnAllowed = true;
        }
    }
}
