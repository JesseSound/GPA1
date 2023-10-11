using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speeddetection : MonoBehaviour
{
    public float playerSpeed;
    public float playerPosX;
    public float playerPosY;
    public void Awake()
    {
        playerSpeed = gameObject.GetComponent<Player>().speed;
        playerPosY = gameObject.GetComponent<Transform>().position.y;
        playerPosX = gameObject.GetComponent<Transform>().position.x;
    }

    // Double speed on-enter
    private void OnTriggerEnter2D(Collider2D collision)
        {
        if (collision.CompareTag("trap"))
        {

            
            Debug.Log(gameObject.name + " is triggered by " + collision.gameObject.name);

            gameObject.GetComponent<Player>().speed /= 2;
        }
        if (collision.CompareTag("Heart"))
        {


            Debug.Log(gameObject.name + " is triggered by " + collision.gameObject.name);
            gameObject.GetComponent<Player>().score += 1;
            Destroy(collision.gameObject);
            Debug.Log("Score is: " + gameObject.GetComponent<Player>().score);
        }

        if (collision.CompareTag("roses"))
        {


            Debug.Log(gameObject.name + " is triggered by " + collision.gameObject.name);
            gameObject.GetComponent<Player>().lives -= 1;
            transform.position =  new Vector3(-8.88f, 2.22f, -0.27f);


        }

    }

        // Reset to original speed on-exit
        private void OnTriggerExit2D(Collider2D collision)
        {
            Debug.Log(gameObject.name + " is no longer triggered by " + collision.gameObject.name);

            gameObject.GetComponent<Player>().speed = playerSpeed;

    }
}
