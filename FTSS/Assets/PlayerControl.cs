using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
 
    private Rigidbody2D rb;

    private float health;

    void Start()
    {
        health = 100;
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate (Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate (Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate (Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate (Vector3.right * Time.deltaTime * speed);
        }
    }
}
