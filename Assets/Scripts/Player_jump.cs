using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_jump : MonoBehaviour
{
    public float jumpforce = 5f;

    private Rigidbody2D myRB;

    private bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        
    }

    public void jump()
    {
        if (canJump)
        {
            canJump = false;
            myRB.velocity = new Vector2(0f, jumpforce);

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        canJump = true;
    }
}