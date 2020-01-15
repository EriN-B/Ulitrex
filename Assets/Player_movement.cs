using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Player_movement : MonoBehaviour
{
    [Range(1 ,10)]
    public float JumpVelocity;
    private Rigidbody2D rb;
    
    private bool canjump;

    public float speed;

    private float moveInput;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed , rb.velocity.y );

        if (Input.GetButtonDown("Jump") && canjump)
        {
            canjump = false;
            rb.velocity = Vector2.up * JumpVelocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        canjump = true;

    }
    
    
}
