using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " is colliding with " + collision.gameObject.name);
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " is no longer colliding with " + collision.gameObject.name);
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
    }
}
