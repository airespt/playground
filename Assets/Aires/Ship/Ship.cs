using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [Range(0.0f, 0.1f)]
    public float accelConstant;
    public Vector2 speed = new Vector2();

    [Range(0.0f, 5.0f)]
    public float angSpdConstant;
    public float angularSpeed;

    public Collider2D collBox;

    [Range(0.0f, 1.0f)]
    public float dampening;

    private float angle;

    void Start()
    {
    }

    public void Left() {
        angularSpeed = angSpdConstant;
    }

    public void Right() {
        angularSpeed = -angSpdConstant;
    }

    public void Forward() {
        var rad = angle * 3.14159f / 180;
        speed.x += accelConstant * Mathf.Cos(rad);
        speed.y += accelConstant * Mathf.Sin(rad);
        Mon.Debug($"quat:{collBox.transform.rotation.z} ang:{angle} rad:{rad} cos:{Mathf.Cos(rad)}");
    }

    public void Dampen(float moveFriction) {
        speed.x -= speed.x * moveFriction;
        speed.y -= speed.y * moveFriction;
    }

    void FixedUpdate() {
        collBox.transform.Rotate(0, 0, angularSpeed);
        angle = (angle + angularSpeed) % 360;
        angularSpeed = 0;

        transform.Translate(speed.x, speed.y, 0);
        Dampen(dampening);
    }
}
