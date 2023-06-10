using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Click_Buy : MonoBehaviour
{
    AudioSource buy;
    // Start is called before the first frame update
    void Start()
    {
        buy = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Destroy(GameObject.FindWithTag("st21"));

            Destroy(GameObject.FindWithTag("bal1"));
            buy.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Destroy(GameObject.FindWithTag("st22"));

            Destroy(GameObject.FindWithTag("bal2"));
            buy.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
             Destroy(GameObject.FindWithTag("st23"));

            Destroy(GameObject.FindWithTag("bal3"));
            buy.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            Destroy(GameObject.FindWithTag("st24"));

            Destroy(GameObject.FindWithTag("bal4"));
            buy.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Destroy(GameObject.FindWithTag("st25"));

            Destroy(GameObject.FindWithTag("bal5"));
            buy.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            Destroy(GameObject.FindWithTag("st11"));

            Destroy(GameObject.FindWithTag("bal1"));
            Destroy(GameObject.FindWithTag("bal2"));
            Destroy(GameObject.FindWithTag("bal3"));
            Destroy(GameObject.FindWithTag("bal4"));
            Destroy(GameObject.FindWithTag("bal5"));
            Destroy(GameObject.FindWithTag("bal6"));
            buy.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(GameObject.FindWithTag("st31"));

            Destroy(GameObject.FindWithTag("bal1"));
            Destroy(GameObject.FindWithTag("bal2"));
            Destroy(GameObject.FindWithTag("bal3"));
            buy.Play(0);
        }

    }
}
