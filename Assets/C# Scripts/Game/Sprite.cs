using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sprite : MonoBehaviour
{
    public static Sprite instance;

    public Rigidbody2D SpriteRigid;

    public float maxSpeed = 10f;
    private bool flipRight = true;

    private float topScore = 0.0f;

    public Text scoreText;

    private GameObject target;
    private GameObject target2;
    private GameObject target3;
    private GameObject target4;
    private GameObject target5;

    private GameObject lose;

    private GameObject player;

    public AudioClip[] musics;
    public AudioSource source;

    public void ChangeMusic(AudioClip clip)
    {
        if (source.isPlaying)
        {
            source.Stop();
        }

        source.clip = clip;
        source.Play();
    }

    private void Flip()
    {
        flipRight = !flipRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            player.SetActive(false);
            lose.transform.localPosition -= new Vector3(900.0f, 0f, 0f);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        source = GetComponent<AudioSource>();
        ChangeMusic(musics[0]);

        target = GameObject.FindWithTag("Background_1");
        target2 = GameObject.FindWithTag("Background_2");
        target3 = GameObject.FindWithTag("Background_3");
        target4 = GameObject.FindWithTag("Background_4");
        target5 = GameObject.FindWithTag("Background_5");

        lose = GameObject.FindWithTag("Game_Over");

        player = GameObject.FindWithTag("Sprite");

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            ChangeMusic(musics[1]);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeMusic(musics[2]);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeMusic(musics[3]);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeMusic(musics[4]);
        }

        if (SpriteRigid.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y - 5;               
        }

        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();

        if (topScore > 99.0f)
        {
            target.transform.localPosition = new Vector3(-5.0f, 0f, 0f);
        }

        if (topScore > 199.0f)
        {
            target2.transform.localPosition = new Vector3(-5.0f, 0f, 0f);
            ChangeMusic(musics[2]);
        }

        if (topScore > 299.0f)
        {
            target3.transform.localPosition = new Vector3(-5.0f, 0f, 0f);
            ChangeMusic(musics[3]);
        }

        if (topScore > 399.0f)
        {
            target4.transform.localPosition = new Vector3(-5.0f, 0f, 0f);
            ChangeMusic(musics[4]);
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if (move > 0 && !flipRight)
        {
            Flip();
        }

        else if (move < 0 && flipRight)
        {
            Flip();
        }
       
    }

}
