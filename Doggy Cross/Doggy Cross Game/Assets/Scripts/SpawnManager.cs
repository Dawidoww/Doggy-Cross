using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnPosZ = 60;
    private float startDelay = 2;
    private float spawnInterval1 = 3.1f;
    private float spawnInterval2 = 2.5f;
    private float spawnInterval3 = 2.8f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar1", startDelay, spawnInterval1);
        InvokeRepeating("SpawnRandomCar2", startDelay, spawnInterval2);
        InvokeRepeating("SpawnRandomCar3", startDelay, spawnInterval3);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomCar1()
    {
        int carIndex1 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos1 = new Vector3(Random.Range(7, 12), 5, spawnPosZ);
        Instantiate(carPrefabs[carIndex1], spawnPos1, carPrefabs[carIndex1].transform.rotation);

    }
    void SpawnRandomCar2()
    {
        int carIndex2 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos2 = new Vector3(Random.Range(16, 22), 5, spawnPosZ);
        Instantiate(carPrefabs[carIndex2], spawnPos2, carPrefabs[carIndex2].transform.rotation);

    }
    void SpawnRandomCar3()
    {
        int carIndex3 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos3 = new Vector3(Random.Range(-3, 3), 5, spawnPosZ);
        Instantiate(carPrefabs[carIndex3], spawnPos3, carPrefabs[carIndex3].transform.rotation);

    }

}
