using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed;
    public int score = 0;
    public int lives = 5;
    public GameObject text;
    public TextMeshProUGUI scoreTotal;
    Rigidbody2D rb;
    public TextMeshProUGUI heartCount;
    public GameObject instructs;

    // Start is called before the first frame update
    void Start()
        
    {
        rb = GetComponent<Rigidbody2D>();
        text.SetActive(false);
        instructs.SetActive(true);
        gameObject.SetActive(true);
        scoreTotal.text = "Score: " + score.ToString();
        heartCount.text = "Hearts: " + lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //score and life count 
        scoreTotal.text = "Score: " + score.ToString();
        heartCount.text = "Hearts: " + lives.ToString();

        //game over condition
        //<= 0 is there in case of glitching
        if (lives <= 0)
        {
            text.SetActive(true);
            gameObject.SetActive(false);
        }
        if (Input.anyKey)
        {
            instructs.SetActive(false);
        }

        //movement
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0.0f, speed);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0.0f, -speed);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0.0f);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0.0f);
        }

        else
        {
            rb.velocity = Vector2.zero;
            // Equivalent to below:
            // new Vector2(0.0f, 0.0f);
        }
    }
}
