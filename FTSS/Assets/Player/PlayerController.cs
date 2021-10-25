using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.deltaTime);
    }

    // OnMovement is called on input
    public void OnMovement(InputAction.CallbackContext value)
    {
        movement = value.ReadValue<Vector2>();
    }
}
