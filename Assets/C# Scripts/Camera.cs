using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform spritePos;

    // Update is called once per frame
    void Update()
    {
        if (spritePos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, spritePos.position.y, transform.position.z);
        }
    }
}
