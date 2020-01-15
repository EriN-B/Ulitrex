using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    
    private float randX;

    private float spawnrate;

    private Vector2 wheretospawn;

    private float nextspawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    
    {
        if (Time.time > nextspawn)
        {     
            spawnrate = Random.Range(0.9f, 1.8f);
            nextspawn = Time.time + spawnrate;
            randX = Random.Range(11f, 11f);
            wheretospawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretospawn, Quaternion.identity);
        } 
    }
}
