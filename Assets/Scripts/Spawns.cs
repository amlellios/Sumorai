using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Spawns : MonoBehaviour
{



    public GameObject spawnee;

    public bool StopSpawning = false;

    public float SpawnTime;

    public float SpawnDelay;



    // Use this for initialization

    void Start()
    {

        InvokeRepeating("SpawnObject", SpawnTime, SpawnDelay);

    }



    public void SpawnObject()
    {

        Instantiate(spawnee, transform.position, transform.rotation);

        if (StopSpawning)
        {

            CancelInvoke("SpawnObject");

        }

    }

}

