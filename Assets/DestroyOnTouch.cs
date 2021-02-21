using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var a = collision.collider.gameObject.GetComponent<CelestialBody>();
        a.radius = 0;
        a.mass = 0;
        a.surfaceGravity = 0;
        a.Rigidbody.isKinematic = true;
        a.gameObject.layer = 10;
        a.GetComponent<SpriteRenderer>().enabled = false;
        a.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var a = collision.gameObject.GetComponent<CelestialBody>();
        a.radius = 0;
        a.mass = 0;
        a.surfaceGravity = 0;
        a.Rigidbody.isKinematic = true;
        a.gameObject.layer = 10;
        a.GetComponent<SpriteRenderer>().enabled = false;
        a.gameObject.SetActive(false);

    }
}
