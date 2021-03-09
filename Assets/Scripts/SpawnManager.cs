using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float xPosRange = 13;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void SpawnRandomAnimal() 
    {
        float randXPos = Random.Range(-xPosRange, xPosRange);
        int animalPrefabIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 randPos = new Vector3(randXPos, 0, 29);
        Instantiate(animalsPrefabs[animalPrefabIndex], randPos,
        animalsPrefabs[animalPrefabIndex].transform.rotation);
    }

}
