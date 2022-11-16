using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    void Start()
    {
        Instantiate(objectToSpawn);
    }
}
