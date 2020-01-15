using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    
    public ScoreManager scoreManager1;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag =="Gift")
        {
            SceneManager.LoadScene(2);
        }
        else if (other.gameObject.tag == "Bird")
        {
            SceneManager.LoadScene(2);
        }
        
    }
    
    
}
