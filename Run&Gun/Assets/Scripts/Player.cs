﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 66;

    private Rigidbody2D rb2d;
    private bool facingRight = true;
    private bool jump;
    private bool onGround = false;
    private Transform groundCheck;
    public float hForce = 0;

    private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        groundCheck = gameObject.transform.Find("GroundCheck");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            onGround = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
            if(Input.GetButtonDown("Jump")&& onGround)
            {
                jump = true;
            }
            else if(Input.GetButtonUp("Jump"))
            {
                if (rb2d.velocity.y > 0)
                {
                    rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * 0.5f);
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if (!isDead)
        {
            //hForce = Input.GetAxisRaw("Horizontal");

            //rb2d.velocity = new Vector2(hForce * speed, rb2d.velocity.y);
            
            if(hForce > 0 && !facingRight)
            {
                Flip();
            }
            if (hForce < 0 && !facingRight)
            {
                Flip();
            }
            if (jump)
            {
                jump = false;
                rb2d.AddForce(Vector2.up * jumpForce);
            }
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
