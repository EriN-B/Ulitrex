using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Collect_coins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "gift");
        {
            Destroy(other.gameObject);
        }
        
        if (other.gameObject.tag=="Player")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene(1);
        }
    }
}
