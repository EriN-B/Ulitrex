using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore_ingame : MonoBehaviour
{
    ScoreManager scoremanager;
    public GameObject Text;

    private void Update()
    {
        if (scoremanager.score > PlayerPrefs.GetInt("Highscore187"))
        {
            Text.SetActive(true);
        }
    }
}
