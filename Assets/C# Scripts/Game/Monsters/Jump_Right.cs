using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Right : MonoBehaviour
{
    float speedMultiplier = 0f;
    float jumpMultiplier = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            speedMultiplier = 1.5f;
            jumpMultiplier = 1f;

            Destroy(gameObject, 5);
        }
        transform.Translate(Vector2.right * Time.deltaTime * speedMultiplier);
        transform.Translate(Vector2.up * Time.deltaTime * jumpMultiplier);
    }
}
