using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sprite"))
        {
            MoneyText.Coin += 1;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            Destroy(gameObject);
        }
    }
}
