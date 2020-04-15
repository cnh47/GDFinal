﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject enemy;

    public Transform[] spawnPoints;

    public Vector3 spawnValues;
    public int howoften = 10;
    public int howmany = 3;
    public float etimer;
    public bool ShouldSpawn = true;


    void Update () {
        if(ShouldSpawn){
            etimer = etimer - Time.deltaTime;
            if(etimer<0){etimer=howoften;

             int i = howmany;
                while(i>0){i--;

                    int spawnPointIndex = Random.Range (0, spawnPoints.Length);

                    Instantiate(enemy,
                            spawnPoints[spawnPointIndex].position,
                            spawnPoints[spawnPointIndex].rotation);
                }
            }
        }
    }
}
