using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPController : MonoBehaviour
{

    [SerializeField] int hp;

    public EventHandler Died;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetHP(int hp)
    {
        this.hp = hp;
    }


    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Die();

        }
    }

    public void Die()
    {
        if (Died != null)
        {

            Died.Invoke(this, EventArgs.Empty);

        }
        gameObject.SetActive(false);

    }
}
