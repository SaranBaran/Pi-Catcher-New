using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent (typeof (Rigidbody2D))]
public class CelestialBody : GravityObject {

    public float radius;
    public float surfaceGravity;
    public Vector3 initialVelocity;
    public string bodyName = "Unnamed";
    public bool isblackhole = false;
    Transform meshHolder;

    public Vector2 velocity { get; private set; }
    public float mass { get; private set; }
    Rigidbody2D rb;

    void Awake () {
        rb = GetComponent<Rigidbody2D> ();
        rb.mass = mass;
        velocity = initialVelocity;
    }

    public void UpdateVelocity (CelestialBody[] allBodies, float timeStep) {
        if (isblackhole) { velocity = Vector2.zero; return; }
        foreach (var otherBody in allBodies) {
            if (otherBody != this) {
                float sqrDst = (otherBody.rb.position - rb.position).sqrMagnitude;
                Vector3 forceDir = (otherBody.rb.position - rb.position).normalized;

                Vector2 acceleration = forceDir * Universe.gravitationalConstant * otherBody.mass / sqrDst;
                velocity += acceleration * timeStep;
            }
        }
    }

    public void UpdateVelocity (Vector2 acceleration, float timeStep) {
        if (isblackhole) { velocity =Vector2.zero ; return; }
        velocity += acceleration * timeStep;
    }

    public void UpdatePosition (float timeStep) {
        rb.MovePosition (rb.position + velocity * timeStep);

    }

    void OnValidate () {
        mass = surfaceGravity * radius * radius / Universe.gravitationalConstant;
        meshHolder = transform.GetChild (0);
        meshHolder.localScale = Vector2.one * radius;
        gameObject.name = bodyName;
    }

    public Rigidbody2D Rigidbody {
        get {
            return rb;
        }
    }

    public Vector3 Position {
        get {
            return rb.position;
        }
    }

}