using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float spawnRangeZ = 15;
    private float spawnRangeZMin = 1f;
    private float spawnPosX = 27;
  
    
    // Start is called before the first frame update
    void Start()
    {
        //This method allows us to use a function many times in orde to repeat with
        //an interval time and a delay before to begin
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {   //Index of the array of animals in the list
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndexTwo = Random.Range(0, animalPrefabs.Length);
        //add spawn to left at right and viceverse
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeZMin, spawnRangeZ));
       //Rotation of the animal
        Vector3 rotation = new Vector3(0, 90, 0);
       // Instantiate(animalPrefabs[animalIndexTwo], spawnPos, animalPrefabs[animalIndexTwo].transform.rotation);
        //Applying the rotation with Quaternion.Euler
        Instantiate(animalPrefabs[animalIndexTwo], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndexThree = Random.Range(0, animalPrefabs.Length);
        //add spawn to left at right and viceverse
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZMin, spawnRangeZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndexThree], spawnPos, Quaternion.Euler(rotation));
    }
}
