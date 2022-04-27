using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombHeartSpawner : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] boxes;
    int randomSpawnPoints, randomBoxes;
    public static bool spawnAllowed;
    public static float bombhearttekraretme;



    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnABox", 0f,bombhearttekraretme);
    }

    void SpawnABox()
    {
        if (spawnAllowed)
        {




            randomSpawnPoints = Random.Range(0, SpawnPoints.Length);
            randomBoxes = Random.Range(0, boxes.Length);
            Instantiate(boxes[randomBoxes], SpawnPoints[randomSpawnPoints].position,
                Quaternion.identity);
        }

    }
}