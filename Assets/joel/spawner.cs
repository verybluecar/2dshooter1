using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnSeconds;
    public GameObject enemy;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObject()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector2 randomPosition = new Vector2(randomX, randomY);
        Instantiate(enemy, randomPosition, Quaternion.identity);
    }
}
