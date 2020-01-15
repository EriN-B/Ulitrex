using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_points : MonoBehaviour
{
    public int BirdValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(BirdValue);
        }
    }
}