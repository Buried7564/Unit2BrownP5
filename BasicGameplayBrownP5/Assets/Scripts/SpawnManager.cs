using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    public GameObject[] animalPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public GameObject[] animals;
    public GameObject[] SideAnimals;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        
    }
    void SpawnAnimalLeft()
    {
        Vector3 spawnPos = new Vector3(-10, 0, Random.Range(5,15));
        int animalIndex = Random.Range(0, animals.Length);
        Instantiate(animals[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.back));

    }
    void SpawnAnimalRight()
    {
        Vector3 spawnPos = new Vector3(10, 0, Random.Range(5, 15));
        int animalIndex = Random.Range(0, animals.Length);
        Instantiate(animals[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.back));

    }
}
