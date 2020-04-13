using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    // public Transform[] m_SpawnPoints;
    // public GameObject m_EnemyPrefab;
    // public int HowMany = 5;
    //
    // // Start is called before the first frame update
    // void Start()
    // {
    //     SpawnNewEnemy();
    // }
    //
    // void OnEnable()
    // {
    //     ZombieController.OnEnemyKilled += SpawnNewEnemy;
    // }
    //
    // void Update () {
    //
    // }
    // void SpawnNewEnemy() {
    //
    //     int randomNumber = Mathf.RoundToInt(Random.Range(0f, m_SpawnPoints.Length-1));
    //
    //     Instantiate(m_EnemyPrefab, m_SpawnPoints[randomNumber].transform.position, Quaternion.identity);
    //
    //
    // }
    public GameObject enemy;

     public Transform[] spawnPoints;

     public Vector3 spawnValues;
     public int howoften = 10;
     public int howmany = 3;
     public float etimer;


     void Update () {



         etimer = etimer - Time.deltaTime;
         if(etimer<0){etimer=howoften;

             int i = howmany;
             while(i>0){i--;

                 int spawnPointIndex = Random.Range (0, spawnPoints.Length);

                 Instantiate(enemy,
                             spawnPoints[spawnPointIndex].position,
                             spawnPoints[spawnPointIndex].rotation);
             }
         }}
}
