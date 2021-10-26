using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 mouse;
    public float speed;

    public PlayerInput player_input;
    public Camera character_cam;
    public Camera ship_cam;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        var dir = mouse - (Vector2) ship_cam.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        var rot = Quaternion.AngleAxis(angle, Vector3.forward);
        //rb.SetRotation(rot);
        rb.AddTorque(angle / 30);
    }


    // Movement Code (Called on movement inputs)
    public void OnMovement(InputAction.CallbackContext value)
    {
        rb.velocity = value.ReadValue<Vector2>() * speed;
    }

    //Called when switching from flying to boarding
    public void switch_controls(InputAction.CallbackContext value)
    {
        //If statement needed to stop unity from crashing due to a lot of function calls
        if (!value.started) return;
        
        //Switch ActionMap to PlayerControls
        player_input.SwitchCurrentActionMap("PlayerControls");
            
        //disable ship_cam, enable player_cam
        ship_cam.gameObject.SetActive(false);
        character_cam.gameObject.SetActive(true);
        
    }

    public void OnMouseMove(InputAction.CallbackContext value)
    {
        mouse = value.ReadValue<Vector2>();
        Debug.Log(mouse);
        //rb.MoveRotation = value.ReadValue<Vector2>();
    }
}
