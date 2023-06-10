using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Generation : MonoBehaviour
{
    public GameObject platformPrefab;
    // Start is called before the first frame update
    void Start()
    {

        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < 620; i++)
        {

            SpawnerPosition.x = Random.Range(-1.0f, 1.0f);
            SpawnerPosition.y += Random.Range(0.8f, 0.8f);

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
