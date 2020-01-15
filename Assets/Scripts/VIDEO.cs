using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIDEO : MonoBehaviour
{
    public GameObject VideoPlayer;
    public int TimeToStop;

    private void Start()
    {
        VideoPlayer.SetActive(true);
    }
    
    
}
