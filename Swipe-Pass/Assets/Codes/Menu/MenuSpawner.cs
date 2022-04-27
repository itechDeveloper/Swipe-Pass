using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpawner : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] objects;
    int randomSpawnPoints, randomBoxes;

    void Start()
    {
        InvokeRepeating("SpawnABox", 0f, 3f);
    }

    void SpawnABox()
    {
            randomSpawnPoints = Random.Range(0, SpawnPoints.Length);
            randomBoxes = Random.Range(0, objects.Length);
            Instantiate(objects[randomBoxes], SpawnPoints[randomSpawnPoints].position,
                Quaternion.identity);
    }
}
