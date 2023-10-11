using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " is colliding with " + collision.gameObject.name);




      
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " is no longer colliding with " + collision.gameObject.name);
        
    }
}
