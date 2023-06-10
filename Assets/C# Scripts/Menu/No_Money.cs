using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_Money : MonoBehaviour
{

    private GameObject NoMoney;

    AudioSource no;
    // Start is called before the first frame update
    void Start()
    {
        NoMoney = GameObject.FindWithTag("NM");
        no = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            NoMoney.transform.localPosition = new Vector3(0f, 0f, 0f);
            no.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            NoMoney.transform.localPosition = new Vector3(-40.2f, 0f, 0f);
        }
    }
}
