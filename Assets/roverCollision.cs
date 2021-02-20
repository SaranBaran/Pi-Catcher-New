using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roverCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Planet)
    {
        if (Planet.tag == "Mars")
        {
            GetComponent<Animator>().SetTrigger("Win");
        }
    }

}
