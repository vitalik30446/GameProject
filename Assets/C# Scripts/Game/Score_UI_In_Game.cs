using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_UI_In_Game : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Destroy(GameObject.FindWithTag("sg11"));
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Destroy(GameObject.FindWithTag("sg21"));
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Destroy(GameObject.FindWithTag("sg31"));
        }
    }
}
