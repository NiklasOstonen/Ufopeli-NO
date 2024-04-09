using System;
using TMPro;
using UnityEngine;

public class PlayerCannon : MonoBehaviour
{
    float mx;
    public float movementSpeed = 5f;
    Rigidbody2D rb;
    [SerializeField] int currentHP;
    [SerializeField] int maxHP;
    [SerializeField] TextMeshProUGUI hpText;
    public EventHandler playerDied;


    // public float moveSpeed = 10;
    // public float hInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        currentHP = maxHP;
        UpdateHpText();
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

    public void TakeDamage(int damage)
    {
        if (currentHP > 0)
        {
            currentHP -= damage;
            UpdateHpText();
            if (currentHP <= 0)
            {
                gameObject.SetActive(false);
                if (playerDied != null)
                {
                    playerDied.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }

            void UpdateHpText()
            {
                if (hpText != null)
                {
                    hpText.text = $" {currentHP} / {maxHP}";
                }
            }
        enum PlayerState
    {
        Alive,
        Pause,
        Dead,
    }
}




