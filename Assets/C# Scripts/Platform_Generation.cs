using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Generation : MonoBehaviour
{

    public GameObject platformPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < 50; i++)
        {
            SpawnerPosition.x = Random.Range(-0.6f, 0.6f);
            SpawnerPosition.y += Random.Range(0.6f, 0.6f);

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
