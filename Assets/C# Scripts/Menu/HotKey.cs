using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HotKey : MonoBehaviour
{

    private GameObject target;

    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Shop");

        source = GetComponent<AudioSource>();
        source.Play(0);
    }

    // Update is called once per frame



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            target.transform.localPosition = new Vector3(-6.3f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            source.Stop();
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            source.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            target.transform.localPosition = new Vector3(-40.2f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
            source.Stop();
        }
    }
}
