using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HotKey : MonoBehaviour
{

    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Shop");
    }

    // Update is called once per frame



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            target.transform.localPosition = new Vector3(-6.3f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            target.transform.localPosition = new Vector3(-40.2f, 0f, 0f);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
