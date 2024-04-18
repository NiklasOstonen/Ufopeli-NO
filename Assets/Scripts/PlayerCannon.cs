using System;
using UnityEngine;

public class PlayerCannon : MonoBehaviour
{
    public int speed;
    Rigidbody2D rb;
    public EventHandler playerDied;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        speed = 100;

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            float turnSpeed = speed * Time.deltaTime;

            //Connect turning rate to horizonal motion for smooth transition
            float rotate = Input.GetAxis("Horizontal") * turnSpeed;

            //Get current rotation
            float currentRotation = gameObject.transform.rotation.z;

            //Add current rotation to rotation rate to get new rotation
            Quaternion rotation = Quaternion.Euler(0, 0, currentRotation + rotate);

            //Move object to new rotation
            gameObject.transform.rotation = rotation;
        }

    }

}




