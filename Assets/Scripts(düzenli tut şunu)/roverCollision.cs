using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roverCollision : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D Mars)
    {
        if (Mars.tag == "Mars")
        {
            //marsa gelince
        }
    }

}
