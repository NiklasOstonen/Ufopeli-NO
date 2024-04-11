using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int Healts = 4;
    public Image[] HealtsUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            Healts -= 1;
            for (int i = 0; i < HealtsUI.Length; i++)
            {
                if (i < Healts)
                {
                    HealtsUI[i].enabled = true;
                }
                else
                {
                    HealtsUI[i].enabled = false;
                }
            }
            if (Healts <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
