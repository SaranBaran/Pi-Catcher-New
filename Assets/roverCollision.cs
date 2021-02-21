using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roverCollision : MonoBehaviour
{

    public AudioSource win;
    public GameObject winCanvas;

    void Start()
    {
        winCanvas.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D Planet)
    {
        if (Planet.tag == "Mars")
        {
            GetComponent<Animator>().SetTrigger("Win");
            Invoke("Active", 3f);
        }
    }

    void Active()
    {
        winCanvas.SetActive(true);
        win.Play();
    }

}
