﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlobalControl : MonoBehaviour
{
    public Collider2D Sun;
    public Ship ship;

    // public float AngDampen;
    // public float AngSpdConstant;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Player.angularSpeed -= AngDampen;
        // if( Input.GetKey(KeyCode.LeftArrow) ) {
        //     Player.angularSpeed -= AngSpdConstant;
        // }
        // if( Input.GetKey(KeyCode.RightArrow) ) {
        //     Player.angularSpeed += AngSpdConstant;
        // }

        // FAIL
        // if( Input.GetKey(KeyCode.LeftArrow) )
        //     Player.angularSpeed = Player.AngSpdConstant;
        // else
        //     Player.angularSpeed = 0;
        // if( Input.GetKey(KeyCode.RightArrow) )
        //     Player.angularSpeed = -Player.AngSpdConstant;
        // else
        //     Player.angularSpeed = 0;

        if( Input.GetKey(KeyCode.LeftArrow) )
            ship.Left();
        else if( Input.GetKey(KeyCode.RightArrow) )
            ship.Right();

        if( Input.GetKey(KeyCode.UpArrow) )
            ship.Forward();


    }

}
