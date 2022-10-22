using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float forceJump;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Sprite.instance.SpriteRigid.velocity = Vector2.up * forceJump;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(0f, 0f);
            float RandY = Random.Range(transform.position.y + 0f, transform.position.y + 0f);

            Destroy(gameObject);

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
