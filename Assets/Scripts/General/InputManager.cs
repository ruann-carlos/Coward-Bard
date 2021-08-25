using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class InputManager : MonoBehaviour
{
    public static Action MovePlayerUp;
    public static Action MovePlayerDown;
    public static Action PlayerJump;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayerUp();
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayerDown();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerJump();
        }
    }
}
