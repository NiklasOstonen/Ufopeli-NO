using System;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int speed;
    Rigidbody2D rb;
    private float spin;
    public EventHandler playerDied;
    public EventHandler playerWin;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        // Switch to 800 x 600 windowed
        Screen.SetResolution(800, 600, true);
    }

    // Update is called once per frame
    void Update()
    {
        spin = Input.GetAxis("Horizontal");

    }
    private void FixedUpdate()
    {
        rb.AddTorque(-spin * speed);
    }
}
