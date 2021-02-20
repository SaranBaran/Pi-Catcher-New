using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManagerNode : MonoBehaviour
{
    public int massKg = 100000;
    public Rigidbody2D rb;
    public Vector2 startVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = massKg;
        GravityManager.RegisterCelestialBody(this);
        rb.velocity = startVelocity*GravityManager.timescale;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
       rb.AddForce( GravityManager.GetForce(this),ForceMode2D.Force);
    }
}
