using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Telegram : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Application.OpenURL("https://web.telegram.org/");

        }
    }
}
