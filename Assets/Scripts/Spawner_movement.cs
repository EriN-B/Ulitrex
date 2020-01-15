using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_movement : MonoBehaviour
{
    public float speed_spawner = 3f;

    private Rigidbody2D RB_Spawner;
    // Start is called before the first frame update
    void Start()
    {
        RB_Spawner = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RB_Spawner.velocity = new Vector2(speed_spawner, 0);
    }
}
