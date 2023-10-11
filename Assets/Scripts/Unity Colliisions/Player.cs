using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public int score = 0;
    public int lives = 5;
    public GameObject text;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
        
    {
        rb = GetComponent<Rigidbody2D>();
        text.SetActive(false);
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (lives <= 0)
        {
            text.SetActive(true);
            gameObject.SetActive(false);
        }



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
