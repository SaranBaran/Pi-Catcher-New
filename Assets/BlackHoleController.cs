using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleController : MonoBehaviour
{
    public Color activeclolor,PassiveColor;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<CelestialBody>().isactive = !GetComponent<CelestialBody>().isactive;
            gameObject.layer = GetComponent<CelestialBody>().isactive ? 0 : 10;
            GetComponent<SpriteRenderer>().color = GetComponent<CelestialBody>().isactive ? activeclolor : PassiveColor;
            if (GetComponent<CelestialBody>().isactive)
            {
                asdf.Start();
            }
            else
            {
                asdf.Stop();
            }
        }
    }
}
