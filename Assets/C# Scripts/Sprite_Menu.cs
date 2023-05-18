using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sprite_Menu : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private Rigidbody2D player;

    float timePassed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > 2.3f)
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            timePassed = 0f;
        }
    }
}

