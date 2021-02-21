using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roverCollision : MonoBehaviour
{

    public AudioSource win;

    void OnTriggerEnter2D(Collider2D Planet)
    {
        if (Planet.tag == "Mars")
        {
            win.Play();
            GetComponent<Animator>().SetTrigger("Win");
        }
    }

}
