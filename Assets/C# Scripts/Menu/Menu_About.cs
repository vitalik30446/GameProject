using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_About : MonoBehaviour
{
    private GameObject ab;
    private GameObject main;

    // Start is called before the first frame update
    void Start()
    {
        ab = GameObject.FindWithTag("About");
        main = GameObject.FindWithTag("Logo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ab.transform.localPosition = new Vector3(-8.0f, 1.0f, 0.1232529f);
            main.SetActive(false);
            
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ab.transform.localPosition = new Vector3(-41.85f, -0.03f, 0.1232529f);
            main.SetActive(true);
            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ab.transform.localPosition = new Vector3(-41.85f, -0.03f, 0.1232529f);
        }
    }
}
