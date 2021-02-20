using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distanceText : MonoBehaviour
{
    [SerializeField]
    public Transform checkpoint;
    [SerializeField]
    public Text distanceTexts;
    private float distance;
    void Update()
    {
        distance = (checkpoint.transform.position - transform.position).magnitude;

        distanceTexts.text = "Distance: " + distance.ToString("F1") + " meters";

        if (distance <= 0)
        {
            distanceTexts.text = "Landed!";
        }
    }
}
