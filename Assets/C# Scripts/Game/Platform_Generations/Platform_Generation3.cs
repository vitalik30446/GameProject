using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Generation3 : MonoBehaviour
{

    public GameObject platformPrefab;
    // Start is called before the first frame update
    void Start()
    {

        Vector3 SpawnerPosition = new Vector3(0.0f, 207f, 0.0f);

        for (int i = 248; i < 372; i++)
        {

            SpawnerPosition.x = Random.Range(-0.7f, 0.7f);
            SpawnerPosition.y += Random.Range(0.8f, 0.8f);

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
