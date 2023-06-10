using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform_trap : MonoBehaviour
{
    private GameObject lose;
    private GameObject player;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Sprite")
        {
            player.SetActive(false);
            lose.transform.localPosition -= new Vector3(900.0f, 0f, 0f);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        lose = GameObject.FindWithTag("Game_Over");
        player = GameObject.FindWithTag("Sprite");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(1);
        }
    }
}
