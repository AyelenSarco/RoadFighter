using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Represents how often a car will be created.
    [SerializeField] float spawnTime;
    [SerializeField] float sleepTime;
    [SerializeField] GameObject enemyCar;
    [SerializeField] Transform[] positions;

    
    void Start(){
        InvokeRepeating("SpawnCar", sleepTime, spawnTime);
    }


    public void SpawnCar(){
        Vector2 position = positions[Random.Range(0, positions.Length)].position;
        Instantiate(enemyCar, position, Quaternion.identity);
    }
}
