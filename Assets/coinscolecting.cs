using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinscolecting : MonoBehaviour
{
    public float coins = 0;
    public TextMeshProUGUI textcoins;
    public AudioSource coinsound;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "coin")
        {
            coins++;
            textcoins.text = coins.ToString();
            coinsound.Play();

            Destroy(collision.gameObject);
        }
    }
    void Start()
    {
        coinsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
