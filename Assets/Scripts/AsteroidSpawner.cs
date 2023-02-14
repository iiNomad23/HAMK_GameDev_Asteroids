using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField]
    private float minX = -9;
    [SerializeField]
    private float minY = 10;
    [SerializeField]
    private float maxX = 9;
    [SerializeField]
    private float maxY = 15;

    private float randomY;
    private float randomX;

    [SerializeField]
    private GameObject asteroid_1;
    [SerializeField]
    private GameObject asteroid_2;

    private void Start()
    {
        InvokeRepeating("SpawnAsteroid_1", 0, 1);
        InvokeRepeating("SpawnAsteroid_2", 0.5f, 1);
    }

    private Vector2 RandomPos()
    {
        randomX = Random.Range(minX, maxX);
        randomY = Random.Range(minY, maxY);

        return new Vector2(randomX, randomY);
    }

    private void SpawnAsteroid_1()
    {   
        Instantiate(asteroid_1, RandomPos(), Quaternion.identity);
    }

    private void SpawnAsteroid_2()
    {           
        Instantiate(asteroid_2, RandomPos(), Quaternion.identity);
    }
}
