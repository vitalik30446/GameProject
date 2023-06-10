using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign_Timer : MonoBehaviour
{
    private GameObject sign1;
    private GameObject sign2;
    private GameObject sign3;
    private GameObject sign4;

    float timePassed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        sign1 = GameObject.FindWithTag("Sign1");
        sign2 = GameObject.FindWithTag("Sign2");
        sign3 = GameObject.FindWithTag("Sign3");
        sign4 = GameObject.FindWithTag("Sign4");
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 0.4f)
            {
                sign1.SetActive(false);
                sign2.SetActive(false);
                sign3.SetActive(false);
                sign4.SetActive(false);

            if (timePassed > 0.8f)
                {
                 sign1.SetActive(true);
                 sign2.SetActive(true);
                 sign3.SetActive(true);
                 sign4.SetActive(true);
                 timePassed = 0f;
                }
            }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            sign1.transform.localPosition += new Vector3(0.0f,-0.15f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            sign4.transform.localPosition += new Vector3(0.15f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            sign2.transform.localPosition += new Vector3(0.0f, 0.15f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            sign3.transform.localPosition += new Vector3(0.0f, 0.15f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            sign1.transform.localPosition += new Vector3(0.0f, 0.15f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            sign4.transform.localPosition += new Vector3(-0.15f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            sign2.transform.localPosition += new Vector3(0.0f, -0.15f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            sign3.transform.localPosition += new Vector3(0.0f, -0.15f, 0.0f);
        }
    }
}
