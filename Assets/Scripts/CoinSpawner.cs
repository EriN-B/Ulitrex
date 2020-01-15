using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    
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
            spawnrate = Random.Range(5f, 12f);
            nextspawn = Time.time + spawnrate;
            randX = Random.Range(11f, 11f);
            wheretospawn = new Vector2(randX, transform.position.y);
            Instantiate(coin, wheretospawn, Quaternion.identity);
        } 
    }
}
