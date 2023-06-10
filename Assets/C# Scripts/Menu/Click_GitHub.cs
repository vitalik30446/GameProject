using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_GitHub : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Application.OpenURL("https://github.com/vitalik30446");

        }
    }
}
