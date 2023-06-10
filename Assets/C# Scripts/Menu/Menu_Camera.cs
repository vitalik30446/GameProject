using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Camera : MonoBehaviour
{

    private GameObject sh;
    private GameObject main;
    // Start is called before the first frame update
    void Start()
    {
        sh = GameObject.FindWithTag("Shop");
        main = GameObject.FindWithTag("Logo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            sh.transform.localPosition = new Vector3(-6.2f, 0f, 0f);
            main.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sh.transform.localPosition = new Vector3(-41.85f, -0.03f, 0.1232529f);
            main.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            sh.transform.localPosition = new Vector3(-41.85f, -0.03f, 0.1232529f);
        }
    }
}
