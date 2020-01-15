using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_space : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;

    private float moveinput;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveinput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveinput * speed, rb.velocity.y);
    }
}
