using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop_Down : MonoBehaviour
{
         private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
        {
        rb2d = GetComponent<Rigidbody2D>();
    }

        // Update is called once per frame
        void Update()
        {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb2d.gravityScale += 0.2f;
            Destroy(gameObject, 5);
        }
    }

}
