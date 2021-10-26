using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
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

    //Called when switching from boarding to flying
    public void switch_controls(InputAction.CallbackContext value)
    {
        //If statement needed to stop unity from crashing due to a lot of function calls
        if (value.started)
        {
            //Switch ActionMap to ShipControls
            player_input.SwitchCurrentActionMap("ShipControls");

            //disable player_cam, enable ship_cam
            character_cam.gameObject.SetActive(false);
            ship_cam.gameObject.SetActive(true);
        }
        
    }
}
