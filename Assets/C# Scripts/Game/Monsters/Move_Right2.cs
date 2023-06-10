using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Right2 : MonoBehaviour
{
    float speedMultiplier = 0f;
    float speedMultiplier2 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            speedMultiplier = 1f;
            speedMultiplier2 = 0.4f;
            Destroy(gameObject, 5);
        }

        transform.Translate(Vector2.right * Time.deltaTime * speedMultiplier);
        transform.Translate(Vector2.down * Time.deltaTime * speedMultiplier2);
    }
}
