using System;
using UnityEngine;

public class PlayerCannon : MonoBehaviour
{
    float mx;
    public float movementSpeed = 5f;
    Rigidbody2D rb;
    public EventHandler playerDied;


    // public float moveSpeed = 10;
    // public float hInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        mx = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
    }

}




