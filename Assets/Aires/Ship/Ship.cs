using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public Vector2 speed = new Vector2();
    public float accelConstant;

    public float angSpdConstant;
    public float angularSpeed;

    new private Collider2D collider;

    void Start()
    {
        collider = GetComponent<Collider2D>();
    }

    public void Left() {
        angularSpeed = angSpdConstant;
    }
    public void Right() {
        angularSpeed = -angSpdConstant;
    }
    public void Forward() {
        var rad = transform.rotation.z * 3.14159f / 180;
        speed.x += accelConstant * Mathf.Cos(rad);
        speed.y += accelConstant * Mathf.Sin(rad);
    }

    void FixedUpdate() {
        transform.Rotate(0, 0, angularSpeed);
        angularSpeed = 0;

        transform.Translate(speed.x, speed.y, 0);
    }
}
