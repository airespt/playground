using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public Vector2 speed = new Vector2();
    public float AngSpdConstant;

    public float angularSpeed;

    new private Collider2D collider;

    void Start()
    {
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    // void Update()
    // {

    // }

    void FixedUpdate() {
        transform.Rotate(0, 0, angularSpeed);
    }
}
