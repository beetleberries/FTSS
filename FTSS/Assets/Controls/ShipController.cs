using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 movement;
    public PlayerInput player_input;
    public Camera character_cam;
    public Camera ship_cam;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Movement Code (Speed calculations)
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.deltaTime);
    }

    // Movement Code (Called on movement inputs)
    public void OnMovement(InputAction.CallbackContext value)
    {
        movement = value.ReadValue<Vector2>();
    }

    //Called when switching from flying to boarding
    public void switch_controls(InputAction.CallbackContext value)
    {
        //If statement needed to stop unity from crashing due to a lot of function calls
        if (value.started)
        {
            //Switch ActionMap to PlayerControls
            player_input.SwitchCurrentActionMap("PlayerControls");
            
            //disable ship_cam, enable player_cam
            ship_cam.gameObject.SetActive(false);
            character_cam.gameObject.SetActive(true);
        }
    }
}
