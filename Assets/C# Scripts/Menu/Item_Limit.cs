using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Limit : MonoBehaviour
{
    private GameObject ItemLimit;

    AudioSource max;
    // Start is called before the first frame update
    void Start()
    {
        ItemLimit = GameObject.FindWithTag("IL");
        max = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ItemLimit.transform.localPosition = new Vector3(0f, 0f, 0f);
            max.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ItemLimit.transform.localPosition = new Vector3(-40.2f, 0f, 0f);
        }
    }
}
