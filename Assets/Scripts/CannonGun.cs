using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonGun : MonoBehaviour
{
    public float cooldowntimer = .5f;
    float timerlength;
    public GameObject bullet;
    public Transform gun1;//, gun2;
    // Start is called before the first frame update
    void Start()
    {
        timerlength = cooldowntimer;
        cooldowntimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && cooldowntimer <= 0) 
        { 
            GameObject.Instantiate(bullet, gun1);
            //GameObject.Instantiate(bullet, gun2);
            cooldowntimer = timerlength;
        }
        if (cooldowntimer >= 0)
        {
            cooldowntimer -= Time.deltaTime;
        }
        
    }
}
