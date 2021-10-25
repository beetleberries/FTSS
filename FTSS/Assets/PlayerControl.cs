using System.Collections;
using UnityEngine;
/*
public class PlayerControl : MonoBehaviour
 {
    //private float health;
    public float speed = 5f;
    private Rigidbody2D rb2D;

    public void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        //health = 100;
    }

    private Vector2 movement = Vector3.zero;

    private void FixedUpdate()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb2D.MovePosition(rb2D.position + movement * speed * Time.fixedDeltaTime);
    }
}*/
public class PlayerControl : MonoBehaviour {

    public float speed = 15f; // let's set a decent speed as default
    private Rigidbody2D rb;

    void Start() // Upper case because in C# casing counts!
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // Let's assign both x and z
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
