using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sprite"))
        {
            MoneyText.Coin += 1;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            Destroy(gameObject, 0.4f);

                source.Play(0);

        }
    }
}
