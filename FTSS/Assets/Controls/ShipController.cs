using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 movement;
    public PlayerInput player_input;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.deltaTime);
    }

    // OnMovement is called on input
    public void ShipOnMovement(InputAction.CallbackContext value)
    {
        movement = value.ReadValue<Vector2>();
    }

    public void Ship_switch_controls(InputAction.CallbackContext value)
    {
        player_input.SwitchCurrentActionMap("PlayerControls");
    }
}
