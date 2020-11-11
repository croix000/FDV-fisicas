using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionIgnorer : MonoBehaviour
{


    [SerializeField] int layerToIgnore;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer== layerToIgnore)
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
