using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoverManager : MonoBehaviour
{
    [SerializeField]
    public Transform checkpoint;
    [SerializeField]
    public Text distanceTexts;
    private float distance;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //distance text için
        distance = (checkpoint.transform.position - transform.position).magnitude;

        distanceTexts.text = "Distance: " + distance.ToString("F1") + " meters";

        if (distance <= 0)
        {
            distanceTexts.text = "Landed!";
        }
    }

    public void OnTriggerEnter2D(Collider2D Planet)
    {
        if (Planet.tag == "notMars")//mars olmayan her şey için
        {
            anim.SetBool("Crash", true);
            Debug.Log("test");
        }
    }

}
