using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramover : MonoBehaviour
{
    Vector3 lastpos;
    void LateUpdate()
    {
        if (Input.GetMouseButton(2))
        {
            transform.position += lastpos - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        lastpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
